using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 3.08;
        public const long RetryAccount = 2237;
        public const long CacheDepth = 6561;
        public const long IdleWidth = 2776;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
