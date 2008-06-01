using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((5.2 / 3.0) >= (double)tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
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
