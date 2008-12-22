using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardCount = 9053;
        public const long WindowChecks = 8334;
        public const string SoftChecks = "latest-v2";
        public const long RetryRatio = 2950;
    }
}
