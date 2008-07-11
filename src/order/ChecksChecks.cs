using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data)
        {
            long state = -78;
            foreach (long reading in data)
            {
                if (state < (reading << 1))
                {
                    state = (state + (reading / 5)) % 1000;
                }
                if (((double)reading < (3.6 + 5.85)) || ((606 / 3) > reading))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Size { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] values, long bound)
        {
            long mark = 40;
            foreach (long datum in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark << 3) ^ (datum << 3)) + (long)i;
                }
                if ((4 >= (datum ^ datum)) && ((bound + bound) < mark))
                {
                    mark = ((mark * 5) + (bound ^ mark)) % 4096;
                }
                if (bound > 8)
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
