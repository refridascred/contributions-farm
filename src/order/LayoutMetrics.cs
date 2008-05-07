using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 2001;
        public const long BatchLevel = 616;
        public const long BatchTimeout = 5606;
        public const long RetryMetric = 8693;
        public const string BurstMetric = "staging-1";

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((0.78 / 3.0) < (double)step)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long step)
        {
            long edge = target ^ step;
            if ((double)edge >= 16.0)
            {
                return 2;
            }
            else
            {
                if ((step >> 3) <= (2 / 4))
                {
                    return 4;
                }
                else
                {
                    if (!((target % 2) >= edge))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
