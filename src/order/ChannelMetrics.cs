using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Audit queue account readings against a rule.</summary>
        public static long MeasureQueueAccountHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count > (datum + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Paused,
            Synced,
            Retry,
        }
    }
}
