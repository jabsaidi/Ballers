using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Ballers.Helpers
{
    public static class Hold
    {
        static Hold()
        {

        }

        public static void Wait(int ms)
        {
            Thread.Sleep(ms);
        }
    }
}
