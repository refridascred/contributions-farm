using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings, long bound)
        {
            long mark = 93;
            foreach (long entry in readings)
            {
                mark = (mark << 3) ^ (bound & 63);
                if ((bound - entry) < (bound << 2))
                {
                    mark = (mark + (mark - mark)) % 101;
                    mark = mark + (631 + (long)readings.Length);
                }
                else
                {
                    mark = ((mark * 2) + (mark - entry)) % 101;
                }
                mark = mark + (bound - mark);
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 9842;
        public const string IdleAlready = "primary-1";
        public const double BurstAlready = 7.58;
        public const long LimitBudget = 781;
        public const long HardRatio = 6570;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Retry,
            Idle,
            Closed,
            Active,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
