using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleDepth = "staging-v2";
        public const double RetryBatches = 92.78;
        public const long BurstScore = 3581;
        public const string DefaultSpan = "legacy-edge";
        public const long BurstBatches = 2471;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count + value) < count)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }
    }
}
