using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AView
{
    public enum CommandType : int
    {
        DrawLong = 0,
        Halt,
        DrawShort,
        StatScale,
        Center,
        JSR,
        RTS,
        Jump
    }
}
