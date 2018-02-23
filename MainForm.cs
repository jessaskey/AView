using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AView
{
    public partial class MainForm : Form
    {
        private byte[] _romBytes = null;
        private Stack<ushort> _addressObjectStack = null;
        private Stack<ushort> _addressSubRoutineStack = null;
        private ushort _currentAddress = 0;
        private ushort _nextAddress = 0;
        //private ushort _baseAddress = 0x6000;
        private int _gridSize = 10;


        private List<string> _colors = new List<string>() { "colblack", "colblue", "colgreen", "colcyan", "colred", "colpurple", "colyellow", "colwhite", "colwhiter", "colpink", "colorange", "colredr", "colred2", "colcyanr", "colbluer", "colgreenr" };
      
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "All Files (*.*)|*.*";
            DialogResult dr = od.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    _romBytes = File.ReadAllBytes(od.FileName);
                    this.Text = "Atari Vector ROM Viewer - " + od.FileName;
                    buttonFirst.Enabled = true;
                    buttonLast.Enabled = true;
                    buttonNext.Enabled = true;
                    buttonPrevious.Enabled = true;
                    numericUpDownScale.Enabled = true;
                    _currentAddress = 0;
                    _addressObjectStack = new Stack<ushort>();
                    _addressSubRoutineStack = new Stack<ushort>();
                    _addressObjectStack.Push(_currentAddress);
                    splitContainer1.Panel1.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Black);

            Brush dotBrush = Brushes.Gray;
            Pen crosshairPen = new Pen(Color.DimGray, 1);

            if (checkBoxShowGrid.Checked)
            {
                for (int i = _gridSize; i < splitContainer1.Panel1.Width; i += _gridSize)
                {
                    for (int j = _gridSize; j < splitContainer1.Panel1.Height; j += _gridSize)
                    {
                        e.Graphics.FillRectangle(dotBrush, i, j, 1, 1);
                    }
                }
            }

            if (checkBoxShowCrosshair.Checked)
            {
                Point center = GetCenter();
                //X Vertical
                g.DrawLine(crosshairPen, new Point(center.X, 0), new Point(center.X, splitContainer1.Panel1.Height));
                //Y Horizontal
                g.DrawLine(crosshairPen, new Point(0, center.Y), new Point(splitContainer1.Panel1.Width, center.Y));
            }

            if (_romBytes != null)
            {
                _nextAddress = DrawObject(g, _currentAddress);
            }
        }

        private ushort DrawObject(Graphics g, ushort objectAddress)
        {
            bool sequentialZeros = false;
            bool drawFlag = true;
            byte intensity = 0;
            Point lastPoint = GetCenter();

            g.RenderingOrigin = lastPoint;

            while (drawFlag)
            {
                VectorCommand command  = new VectorCommand(GetNextCommand(objectAddress));
                labelCurrentAddress.Text = "0x" + _currentAddress.ToString("X4");
                if (checkBoxShowSourceAddress.Checked)
                {
                    textBoxSource.Text += "0x" + objectAddress.ToString("X4") + ": ";
                }
                objectAddress += 2;
                if (!command.IsValid || sequentialZeros) break;

                switch (command.Command)
                {
                    case CommandType.DrawLong:
                        //get another command
                        VectorCommand command2 = new VectorCommand(GetNextCommand(objectAddress));
                        objectAddress += 2;

                        ushort vx = (ushort)((command2.CommandHigh << 8) + command2.CommandLow);
                        ushort vy = (ushort)((command.CommandHigh << 8) + command.CommandLow);

                        intensity = (byte)((vx & 0xe000) >> 13);

                        if (vx == 0 && vy == 0 && intensity == 0)
                        {
                            //this is a long with Zeros for all values, good chance this is just blank bytes in the ROM
                            sequentialZeros = true;
                        }

                        short x = 0;
                        short y = 0;
                        if ((vx & 0x1000) > 0)
                        {
                            x = (short)(vx | unchecked(0xf000));
                        }
                        else
                        {
                            x = (short)(vx & 0x0fff);
                        }

                        if ((vy & 0x1000) > 0)
                        {
                            y = (short)(vy | unchecked(0xf000));
                        }
                        else
                        {
                            y = (short)(vy & 0x0fff);
                        }

                        lastPoint = DrawLine(g, lastPoint, new Point( x, y), intensity);

                        textBoxSource.Text += (checkBoxForceVCTRL.Checked?"vctrl":"vctr") + "(" + x.ToString() + "d," + y.ToString() + "d," + (intensity > 0 ? "visible" : "hidden") + ")" + GetSourceLineTerminator();
                        break;
                    case CommandType.Halt:
                        drawFlag = false;
                        textBoxSource.Text += "vhalt" + GetSourceLineTerminator();
                        break;
                    case CommandType.DrawShort:
                        intensity = (byte)((command.CommandLow & 0xe0) >> 5);
                        sbyte shortVectorX = 0;
                        sbyte shortVectorY = 0;
                        if ((command.CommandLow & 0x10) > 0)
                        {
                            shortVectorX = (sbyte)(command.CommandLow | 0xf0);
                        }
                        else
                        {
                            shortVectorX = (sbyte)(command.CommandLow & 0x0f);
                        }
                        if ((command.CommandHigh & 0x10) > 0)
                        {
                            shortVectorY  = (sbyte)(command.CommandHigh | 0xf0);
                        }
                        else
                        {
                            shortVectorY = (sbyte)(command.CommandHigh & 0x0f);
                        }
                        
                        lastPoint = DrawLine(g, lastPoint, new Point(shortVectorX*2, shortVectorY*2), intensity);
                        textBoxSource.Text += (checkBoxForceVCTRL.Checked ? "vctrl" : "vctr") + "(" + (shortVectorX*2).ToString() + "d," + (shortVectorY*2).ToString() + "d," + (intensity > 0 ? "visible" : "hidden") + ")" + GetSourceLineTerminator();
                        break;
                    case CommandType.StatScale:
                        bool flag = ((command.CommandHigh & 0x10) > 0);
                        if (flag)
                        {
                            //scale
                            bool window = ((command.CommandHigh & 0x08) > 0);
                            int scale_binary = (command.CommandHigh & 0x07);
                            textBoxSource.Text += "vscal(" + (window ? "ywin_on" : "ywin_off") + "," + "binscal" + scale_binary.ToString() + ",$" + command.CommandLow.ToString("X2").ToUpper() + ")" + GetSourceLineTerminator();
                        }
                        else
                        {
                            //stat
                            bool sparkle = ((command.CommandHigh & 0x08) > 0);
                            bool xflip = ((command.CommandHigh & 0x04) > 0);
                            int page = (command.CommandHigh & 0x03);

                            int stat_intensity = ((command.CommandLow >> 4) & 0xf);
                            int stat_color = (command.CommandLow & 0x0f);

                            textBoxSource.Text += "vstat(" + (sparkle ? "sparkle_on" : "sparkle_off") + "," + (xflip ? "xflip_on" : "xflip_off") + ",vpage" + page.ToString() + ",$" + stat_intensity.ToString("X1").ToUpper() + "," + _colors[stat_color] + ")" + GetSourceLineTerminator();
                            //vstat(sp, xf, pg, int, clr) \ .db((int * 16) + clr), ($60 | (((sp * 8) & 8) + ((xf * 4) & 4) + (pg & 3)))
                        }
                        //textBoxSource.Text += "STATSCAL(X)\r\n";
                        break;
                    case CommandType.Center:
                        lastPoint = GetCenter();
                        textBoxSource.Text += "vcntr" + GetSourceLineTerminator();
                        break;
                    case CommandType.Jump:
                        ushort jumpAddress = (ushort)(((((ushort)command.CommandHigh) << 9) + ((((ushort)command.CommandLow) << 1) + 1)) & 0x7FFF);
                        jumpAddress -= (ushort)numericUpDownROMBase.Value;
                        if (checkBoxFollowCode.Checked)
                        {                    
                            _currentAddress = jumpAddress;
                        }
                        //X
                        drawFlag = false;
                        textBoxSource.Text += "jmpl($" + (jumpAddress-0x1000).ToString("X4") + GetSourceLineTerminator();
                        break;
                    case CommandType.RTS:
                        drawFlag = false;
                        textBoxSource.Text += "rtsl" + GetSourceLineTerminator();
                        break;
                    case CommandType.JSR:
                        //_addressSubRoutineStack.Push(objectAddress);
                        ushort subroutineAddress = (ushort)(((((ushort)command.CommandHigh) << 9) + ((((ushort)command.CommandLow) << 1))) & 0x7FFF);

                        if (checkBoxFollowCode.Checked)
                        {
                            textBoxSource.Text += "jsrl($" + subroutineAddress.ToString("X4") + ")" + GetSourceLineTerminator();
                            DrawObject(g, (ushort)(subroutineAddress- (ushort)numericUpDownROMBase.Value));
                            //objectAddress = _addressSubRoutineStack.Pop(); 
                        }
                        else
                        {
                            //X
                            drawFlag = false;
                            textBoxSource.Text += "jsrl($" + subroutineAddress.ToString("X4") + ")" + GetSourceLineTerminator();
                        }
                        
                        break;
                }
            }
            return objectAddress;
        }

        private string GetSourceLineTerminator()
        {
            if (checkBoxSingleLineSource.Checked)
            {
                return " \\ ";
            }
            return "\r\n";
        }

        private Point DrawLine(Graphics g, Point from, Point to, byte intensity)
        {
            Pen pen = null;

            if (checkBoxDrawHiddenLines.Checked)
            {
                pen = new Pen(Color.DarkGray, 1);
            }
            if (intensity > 0)
            {
                pen = new Pen(Color.Red, 2);
            }

            double scale = ((double)numericUpDownScale.Value) / 100d;
            Point scaledTo = new Point((int)((double)(to.X) * scale), (int)((double)(to.Y) * scale));
            to = new Point(from.X + scaledTo.X, from.Y - scaledTo.Y);
            //new point is always relative to the old point
            if (pen != null)
            {
                g.DrawLine(pen, from, to);
            }

            return to;
        }

        private Tuple<byte, byte> GetNextCommand(ushort baseAddress)
        {
            byte commandLow = 0;
            byte commandHigh = 0;
            if (_romBytes != null)
            {
                if (baseAddress < _romBytes.Length)
                {
                    commandLow = _romBytes[baseAddress];
                    baseAddress++;
                }
                if (baseAddress < _romBytes.Length)
                {
                    commandHigh = _romBytes[baseAddress];
                    baseAddress++;
                }
            }
            return new Tuple<byte, byte>(commandLow, commandHigh);
        }


        private Point GetCenter()
        {
            int x = (splitContainer1.Panel1.Width - (splitContainer1.Panel1.Width % (_gridSize * 2))) / 2;
            int y = (splitContainer1.Panel1.Height - (splitContainer1.Panel1.Height % (_gridSize * 2))) / 2;
            return new Point(x, y);
        }

        private void checkBoxShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Invalidate();
        }

        private void checkBoxShowCrosshair_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Invalidate();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            textBoxSource.Text = "";
            _currentAddress = _nextAddress;
            _addressObjectStack.Push(_currentAddress);
            buttonPrevious.Enabled = true;
            buttonFirst.Enabled = true;
            splitContainer1.Panel1.Invalidate();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            textBoxSource.Text = "";
            if (_addressObjectStack.Count > 0)
            {
                _currentAddress = _addressObjectStack.Pop();
                splitContainer1.Panel1.Invalidate();
                if (_addressObjectStack.Count == 0)
                {
                    buttonPrevious.Enabled = false;
                    buttonFirst.Enabled = false;
                }
            }
            else
            {
                buttonPrevious.Enabled = false;
                buttonFirst.Enabled = false;
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            buttonFirst.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButtonBinaryCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxBinary.Text);
        }

        private void toolStripButtonSourceCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxSource.Text);
        }

        private void buttonJumpTo_Click(object sender, EventArgs e)
        {
            textBoxSource.Text = "";

            ushort newAddress = Convert.ToUInt16(textBoxJumpTo.Text, 16);
            _currentAddress = newAddress;
            _addressObjectStack.Push(_currentAddress);
            buttonPrevious.Enabled = true;
            buttonFirst.Enabled = true;
            splitContainer1.Panel1.Invalidate();
        }

        private void checkBoxAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBoxAlwaysOnTop.Checked;
        }

        private void numericUpDownScale_ValueChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Invalidate();
        }
    }
}
