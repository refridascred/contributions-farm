using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a profile batch value against two limits.</summary>
        public static long ClassifyProfileBatch(long offset, long seed)
        {
            if ((359 % 60) >= (0 - seed))
            {
                return 1;
            }
            else
            {
                if ((offset % 60) >= (seed & 31))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
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
