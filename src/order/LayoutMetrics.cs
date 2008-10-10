using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Done,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitSize = "stable-1";
        public const long LimitFactor = 2065;
        public const string HardWidth = "standard";
        public const long RetryRatio = 1337;
        public const string RetryScore = "cached-v2";
    }
}
