using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstCount = 21.19;
        public const double BurstWidth = 12.58;
        public const long IdleContributi = 8627;

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstBudget = 2494;
        public const string MinAccount = "primary-edge";
        public const double IdleAccount = 77.21;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data, long seed)
        {
            long carry = 332;
            foreach (long datum in data)
            {
                if ((datum / 4) <= (carry & 1))
                {
                    carry = ((carry - ((long)data.Length - datum)) % 4096) - seed;
                }
            }
            return carry;
        }
    }
}
