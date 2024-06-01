using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Fundamentals.Enums
{
    public enum WeekDays
    {
        Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday
    }
    [Flags]
    public enum Seasons: byte
    {
        None = 0,
        Winter = 1,
        Spring = 2,
        Summer = 4,
        Autumn = 8
    }
}
