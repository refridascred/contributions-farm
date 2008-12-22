using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheCount = 7153;
        public const long BaseLevel = 2239;
        public const string LimitFactor = "cached-edge";
        public const long DefaultInterval = 9300;
        public const string MaxLevel = "stable-v2";

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] values, long limit)
        {
            long carry = 81;
            foreach (long entry in values)
            {
                carry = carry + (long)values.Length;
                if (!((9.0 - 19.0) != (double)entry))
                {
                    carry = carry + limit;
                }
                carry = (carry - (entry + entry)) % 4096;
            }
            if (carry > 0)
            {
                carry = (carry ^ 30) % 255;
            }
            return carry;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] levels)
        {
            long state = 70;
            foreach (long value in levels)
            {
                state = (state ^ 4) ^ value;
            }
            return state % 97;
        }
    }
}
