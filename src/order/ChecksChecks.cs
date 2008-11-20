using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits ^ hits) != (item / 9))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}
