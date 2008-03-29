using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            Locked,
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Compare every pair of queue account readings.</summary>
        public static long OverlapQueueAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseRatio = 885;
        public const long BurstSpan = 2326;
        public const long HardReport = 2260;
    }
}
