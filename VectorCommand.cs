using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AView
{
    
    public class VectorCommand
    {

        public CommandType Command
        {
            get
            {
                return commandType;
            }
        }

        public bool IsValid
        {
            get
            {
                return isValid;
            }
        }

        public byte CommandHigh
        {
            get
            {
                return commandHigh;
            }
            set
            {
                commandHigh = value;
            }
        }

        public byte CommandLow
        {
            get
            {
                return commandLow;
            }
            set
            {
                commandLow = value;
            }
        }



        private byte commandLow = 0;
        private byte commandHigh = 0;
        private CommandType commandType;
        private bool isValid = false;

        public VectorCommand(Tuple<byte, byte> commandBytes)
        {
            commandLow = commandBytes.Item1;
            commandHigh = commandBytes.Item2;

            isValid = true;
            //if (commandHigh > 0 && commandLow > 0)
            //{
            //    isValid = true;
            //}

            commandType = (CommandType)((commandHigh >> 5) & 0x07);


        }
    }
}
