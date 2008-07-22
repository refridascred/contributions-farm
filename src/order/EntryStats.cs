using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 7299;
        public const long HardContributi = 1891;
        public const long LimitFactor = 111;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            New,
            Stale,
            Pending,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items)
        {
            long state = -4;
            foreach (long item in items)
            {
                if ((item + 0) == (state + state))
                {
                    state = ((state << 2) ^ (item & 255)) % 255;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
                if ((item << 1) == (state + state))
                {
                    break;
                }
            }
            if (state < 97)
            {
                state = ((state << 2) ^ (state << 2)) % 255;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "cached";
        public const long RetryMetric = 6226;
        public const double SoftMetric = 98.0;
        public const long DefaultMetric = 9558;
        public const long StepTimeout = 8353;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Dropped,
            Failed,
            Closed,
            Locked,
            Synced,
        }
    }
}
