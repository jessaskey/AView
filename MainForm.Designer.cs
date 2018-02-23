namespace AView
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numericUpDownROMBase = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonJumpTo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxJumpTo = new System.Windows.Forms.TextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSourceCopy = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxBinary = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBinaryCopy = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxShowSourceAddress = new System.Windows.Forms.CheckBox();
            this.checkBoxAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.checkBoxSingleLineSource = new System.Windows.Forms.CheckBox();
            this.checkBoxForceVCTRL = new System.Windows.Forms.CheckBox();
            this.checkBoxFollowCode = new System.Windows.Forms.CheckBox();
            this.checkBoxShowCrosshair = new System.Windows.Forms.CheckBox();
            this.checkBoxShowGrid = new System.Windows.Forms.CheckBox();
            this.labelCurrentAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDVG = new System.Windows.Forms.RadioButton();
            this.radioButtonAVG = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownScale = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.checkBoxDrawHiddenLines = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownROMBase)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownROMBase);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.buttonJumpTo);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxJumpTo);
            this.splitContainer1.Panel2.Controls.Add(this.tabControlMain);
            this.splitContainer1.Panel2.Controls.Add(this.labelCurrentAddress);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.buttonLast);
            this.splitContainer1.Panel2.Controls.Add(this.buttonNext);
            this.splitContainer1.Panel2.Controls.Add(this.buttonPrevious);
            this.splitContainer1.Panel2.Controls.Add(this.buttonFirst);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownScale);
            this.splitContainer1.Size = new System.Drawing.Size(899, 467);
            this.splitContainer1.SplitterDistance = 495;
            this.splitContainer1.TabIndex = 0;
            // 
            // numericUpDownROMBase
            // 
            this.numericUpDownROMBase.Hexadecimal = true;
            this.numericUpDownROMBase.Increment = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDownROMBase.Location = new System.Drawing.Point(230, 45);
            this.numericUpDownROMBase.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownROMBase.Name = "numericUpDownROMBase";
            this.numericUpDownROMBase.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownROMBase.TabIndex = 19;
            this.numericUpDownROMBase.Value = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "ROM Base:";
            // 
            // buttonJumpTo
            // 
            this.buttonJumpTo.Location = new System.Drawing.Point(274, 89);
            this.buttonJumpTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonJumpTo.Name = "buttonJumpTo";
            this.buttonJumpTo.Size = new System.Drawing.Size(12, 19);
            this.buttonJumpTo.TabIndex = 16;
            this.buttonJumpTo.Text = ">";
            this.buttonJumpTo.UseVisualStyleBackColor = true;
            this.buttonJumpTo.Click += new System.EventHandler(this.buttonJumpTo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "JumpTo:";
            // 
            // textBoxJumpTo
            // 
            this.textBoxJumpTo.Location = new System.Drawing.Point(205, 90);
            this.textBoxJumpTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxJumpTo.Name = "textBoxJumpTo";
            this.textBoxJumpTo.Size = new System.Drawing.Size(66, 20);
            this.textBoxJumpTo.TabIndex = 14;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlMain.Location = new System.Drawing.Point(0, 223);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(400, 244);
            this.tabControlMain.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxSource);
            this.tabPage1.Controls.Add(this.toolStrip3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(392, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Source";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSource.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSource.Location = new System.Drawing.Point(2, 27);
            this.textBoxSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSource.Size = new System.Drawing.Size(388, 189);
            this.textBoxSource.TabIndex = 0;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSourceCopy});
            this.toolStrip3.Location = new System.Drawing.Point(2, 2);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(388, 25);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButtonSourceCopy
            // 
            this.toolStripButtonSourceCopy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonSourceCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSourceCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSourceCopy.Image")));
            this.toolStripButtonSourceCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSourceCopy.Name = "toolStripButtonSourceCopy";
            this.toolStripButtonSourceCopy.Size = new System.Drawing.Size(39, 22);
            this.toolStripButtonSourceCopy.Text = "Copy";
            this.toolStripButtonSourceCopy.Click += new System.EventHandler(this.toolStripButtonSourceCopy_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxBinary);
            this.tabPage3.Controls.Add(this.toolStrip2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(292, 218);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Binary Source";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxBinary
            // 
            this.textBoxBinary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBinary.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBinary.Location = new System.Drawing.Point(2, 27);
            this.textBoxBinary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBinary.Multiline = true;
            this.textBoxBinary.Name = "textBoxBinary";
            this.textBoxBinary.Size = new System.Drawing.Size(288, 189);
            this.textBoxBinary.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBinaryCopy});
            this.toolStrip2.Location = new System.Drawing.Point(2, 2);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(288, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonBinaryCopy
            // 
            this.toolStripButtonBinaryCopy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonBinaryCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBinaryCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBinaryCopy.Image")));
            this.toolStripButtonBinaryCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBinaryCopy.Name = "toolStripButtonBinaryCopy";
            this.toolStripButtonBinaryCopy.Size = new System.Drawing.Size(39, 22);
            this.toolStripButtonBinaryCopy.Text = "Copy";
            this.toolStripButtonBinaryCopy.Click += new System.EventHandler(this.toolStripButtonBinaryCopy_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxDrawHiddenLines);
            this.tabPage2.Controls.Add(this.checkBoxShowSourceAddress);
            this.tabPage2.Controls.Add(this.checkBoxAlwaysOnTop);
            this.tabPage2.Controls.Add(this.checkBoxSingleLineSource);
            this.tabPage2.Controls.Add(this.checkBoxForceVCTRL);
            this.tabPage2.Controls.Add(this.checkBoxFollowCode);
            this.tabPage2.Controls.Add(this.checkBoxShowCrosshair);
            this.tabPage2.Controls.Add(this.checkBoxShowGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(392, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowSourceAddress
            // 
            this.checkBoxShowSourceAddress.AutoSize = true;
            this.checkBoxShowSourceAddress.Location = new System.Drawing.Point(20, 111);
            this.checkBoxShowSourceAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxShowSourceAddress.Name = "checkBoxShowSourceAddress";
            this.checkBoxShowSourceAddress.Size = new System.Drawing.Size(146, 17);
            this.checkBoxShowSourceAddress.TabIndex = 19;
            this.checkBoxShowSourceAddress.Text = "Show Address on Source";
            this.checkBoxShowSourceAddress.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlwaysOnTop
            // 
            this.checkBoxAlwaysOnTop.AutoSize = true;
            this.checkBoxAlwaysOnTop.Location = new System.Drawing.Point(20, 178);
            this.checkBoxAlwaysOnTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxAlwaysOnTop.Name = "checkBoxAlwaysOnTop";
            this.checkBoxAlwaysOnTop.Size = new System.Drawing.Size(92, 17);
            this.checkBoxAlwaysOnTop.TabIndex = 18;
            this.checkBoxAlwaysOnTop.Text = "Always on top";
            this.checkBoxAlwaysOnTop.UseVisualStyleBackColor = true;
            this.checkBoxAlwaysOnTop.CheckedChanged += new System.EventHandler(this.checkBoxAlwaysOnTop_CheckedChanged);
            // 
            // checkBoxSingleLineSource
            // 
            this.checkBoxSingleLineSource.AutoSize = true;
            this.checkBoxSingleLineSource.Location = new System.Drawing.Point(20, 155);
            this.checkBoxSingleLineSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSingleLineSource.Name = "checkBoxSingleLineSource";
            this.checkBoxSingleLineSource.Size = new System.Drawing.Size(115, 17);
            this.checkBoxSingleLineSource.TabIndex = 17;
            this.checkBoxSingleLineSource.Text = "Single Line Source";
            this.checkBoxSingleLineSource.UseVisualStyleBackColor = true;
            // 
            // checkBoxForceVCTRL
            // 
            this.checkBoxForceVCTRL.AutoSize = true;
            this.checkBoxForceVCTRL.Location = new System.Drawing.Point(20, 133);
            this.checkBoxForceVCTRL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxForceVCTRL.Name = "checkBoxForceVCTRL";
            this.checkBoxForceVCTRL.Size = new System.Drawing.Size(91, 17);
            this.checkBoxForceVCTRL.TabIndex = 16;
            this.checkBoxForceVCTRL.Text = "Force VCTRL";
            this.checkBoxForceVCTRL.UseVisualStyleBackColor = true;
            // 
            // checkBoxFollowCode
            // 
            this.checkBoxFollowCode.AutoSize = true;
            this.checkBoxFollowCode.Location = new System.Drawing.Point(20, 90);
            this.checkBoxFollowCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxFollowCode.Name = "checkBoxFollowCode";
            this.checkBoxFollowCode.Size = new System.Drawing.Size(105, 17);
            this.checkBoxFollowCode.TabIndex = 15;
            this.checkBoxFollowCode.Text = "Follow JMP/JSR";
            this.checkBoxFollowCode.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowCrosshair
            // 
            this.checkBoxShowCrosshair.AutoSize = true;
            this.checkBoxShowCrosshair.Checked = true;
            this.checkBoxShowCrosshair.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowCrosshair.Location = new System.Drawing.Point(20, 67);
            this.checkBoxShowCrosshair.Name = "checkBoxShowCrosshair";
            this.checkBoxShowCrosshair.Size = new System.Drawing.Size(75, 17);
            this.checkBoxShowCrosshair.TabIndex = 14;
            this.checkBoxShowCrosshair.Text = "Show Axis";
            this.checkBoxShowCrosshair.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowGrid
            // 
            this.checkBoxShowGrid.AutoSize = true;
            this.checkBoxShowGrid.Checked = true;
            this.checkBoxShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowGrid.Location = new System.Drawing.Point(20, 44);
            this.checkBoxShowGrid.Name = "checkBoxShowGrid";
            this.checkBoxShowGrid.Size = new System.Drawing.Size(75, 17);
            this.checkBoxShowGrid.TabIndex = 13;
            this.checkBoxShowGrid.Text = "Show Grid";
            this.checkBoxShowGrid.UseVisualStyleBackColor = true;
            // 
            // labelCurrentAddress
            // 
            this.labelCurrentAddress.Location = new System.Drawing.Point(104, 93);
            this.labelCurrentAddress.Name = "labelCurrentAddress";
            this.labelCurrentAddress.Size = new System.Drawing.Size(44, 14);
            this.labelCurrentAddress.TabIndex = 9;
            this.labelCurrentAddress.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Current Address:";
            // 
            // buttonLast
            // 
            this.buttonLast.Enabled = false;
            this.buttonLast.Location = new System.Drawing.Point(178, 173);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(35, 23);
            this.buttonLast.TabIndex = 7;
            this.buttonLast.Text = "Last";
            this.buttonLast.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(111, 173);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(59, 23);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Enabled = false;
            this.buttonPrevious.Location = new System.Drawing.Point(52, 173);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(59, 23);
            this.buttonPrevious.TabIndex = 5;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Enabled = false;
            this.buttonFirst.Location = new System.Drawing.Point(11, 173);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(35, 23);
            this.buttonFirst.TabIndex = 4;
            this.buttonFirst.Text = "First";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Object Navigation:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDVG);
            this.groupBox1.Controls.Add(this.radioButtonAVG);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(5, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vector Decoding Method:";
            // 
            // radioButtonDVG
            // 
            this.radioButtonDVG.AutoSize = true;
            this.radioButtonDVG.Location = new System.Drawing.Point(98, 31);
            this.radioButtonDVG.Name = "radioButtonDVG";
            this.radioButtonDVG.Size = new System.Drawing.Size(48, 17);
            this.radioButtonDVG.TabIndex = 1;
            this.radioButtonDVG.TabStop = true;
            this.radioButtonDVG.Text = "DVG";
            this.radioButtonDVG.UseVisualStyleBackColor = true;
            // 
            // radioButtonAVG
            // 
            this.radioButtonAVG.AutoSize = true;
            this.radioButtonAVG.Checked = true;
            this.radioButtonAVG.Location = new System.Drawing.Point(27, 31);
            this.radioButtonAVG.Name = "radioButtonAVG";
            this.radioButtonAVG.Size = new System.Drawing.Size(47, 17);
            this.radioButtonAVG.TabIndex = 0;
            this.radioButtonAVG.TabStop = true;
            this.radioButtonAVG.Text = "AVG";
            this.radioButtonAVG.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scale %:";
            // 
            // numericUpDownScale
            // 
            this.numericUpDownScale.Enabled = false;
            this.numericUpDownScale.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownScale.Location = new System.Drawing.Point(230, 23);
            this.numericUpDownScale.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScale.Name = "numericUpDownScale";
            this.numericUpDownScale.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownScale.TabIndex = 0;
            this.numericUpDownScale.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownScale.ValueChanged += new System.EventHandler(this.numericUpDownScale_ValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(899, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonOpen.ToolTipText = "Load ROM Image";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // checkBoxDrawHiddenLines
            // 
            this.checkBoxDrawHiddenLines.AutoSize = true;
            this.checkBoxDrawHiddenLines.Location = new System.Drawing.Point(20, 21);
            this.checkBoxDrawHiddenLines.Name = "checkBoxDrawHiddenLines";
            this.checkBoxDrawHiddenLines.Size = new System.Drawing.Size(116, 17);
            this.checkBoxDrawHiddenLines.TabIndex = 20;
            this.checkBoxDrawHiddenLines.Text = "Draw Hidden Lines";
            this.checkBoxDrawHiddenLines.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 494);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Atari Vector ROM Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownROMBase)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownScale;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDVG;
        private System.Windows.Forms.RadioButton radioButtonAVG;
        private System.Windows.Forms.Label labelCurrentAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxFollowCode;
        private System.Windows.Forms.CheckBox checkBoxShowCrosshair;
        private System.Windows.Forms.CheckBox checkBoxShowGrid;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonBinaryCopy;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButtonSourceCopy;
        private System.Windows.Forms.TextBox textBoxBinary;
        private System.Windows.Forms.Button buttonJumpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxJumpTo;
        private System.Windows.Forms.CheckBox checkBoxSingleLineSource;
        private System.Windows.Forms.CheckBox checkBoxForceVCTRL;
        private System.Windows.Forms.CheckBox checkBoxAlwaysOnTop;
        private System.Windows.Forms.CheckBox checkBoxShowSourceAddress;
        private System.Windows.Forms.NumericUpDown numericUpDownROMBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxDrawHiddenLines;
    }
}

