namespace HappyNewYear
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public static class HappyNewYear
    {
        private static int newYear;

        static HappyNewYear()
        {
            newYear = 2017;
        }

        public static int MoveToTheNextYear()
        {
            return Interlocked.Increment(ref newYear);
        }
    }
}
