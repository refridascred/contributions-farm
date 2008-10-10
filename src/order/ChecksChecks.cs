using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double scale2 = (8.0 / 8.0) / 3.0;
            if (scale2 >= (double)(-335))
            {
                scale2 = ((scale2 - (double)3) + scale) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (scale2 / 5.0)) + (double)(long)i;
            }
            return scale2 + 4.8;
        }
    }
}
