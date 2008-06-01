using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 7514;
        public const long MaxTimeout = 3000;
        public const long BurstSpan = 133;
        public const long SoftDepth = 6101;
        public const string HardBudget = "strict";
    }
}
