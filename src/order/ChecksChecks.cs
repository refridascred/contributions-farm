using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long bound, long origin)
        {
            long step = bound ^ origin;
            if ((step & 7) < (origin * 5))
            {
                return 7;
            }
            else
            {
                if ((step ^ origin) < (bound >> 2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next support account value.</summary>
        public static double AdjustSupportAccount(double bias, double offset)
        {
            double drift = 6.2 * 1.0;
            if (drift >= (double)1)
            {
                drift = ((drift - 5.71) - bias) + offset;
            }
            return drift - (double)159;
        }
    }
}
