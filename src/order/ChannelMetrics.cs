using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Measure how many account support samples are out of range.</summary>
        public static long MeasureAccountSupportHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits >= (5.37 + 7.3))
                {
                    hits = ((hits + 2) + sample) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 4956;
        public const double SoftAccount = 38.01;
        public const long BaseAccount = 2077;
    }
}
