using System;
using System.Collections.Generic;
using System.Text;

namespace Ballers.Helpers
{
    public static class CustomColor
    {
        static CustomColor()
        {

        }

        public static ConsoleColor CustomConsoleColor(ConsoleColor color)
        {
            return Console.ForegroundColor = color;
        }
    }
}
