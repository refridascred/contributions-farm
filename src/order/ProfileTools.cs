using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheScore = 5.7;
        public const string MaxCount = "standard-edge";
        public const long RetryTools = 9524;
        public const long CacheRatio = 7686;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Locked,
            Draft,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Dropped,
            New,
            Stale,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
