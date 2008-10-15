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

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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
