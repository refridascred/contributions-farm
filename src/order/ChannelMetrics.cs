using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many format report samples are out of range.</summary>
        public static long TallyFormatReportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (entry > (entry * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context cluster readings.</summary>
        public static long TotalContextCluster(long[] samples)
        {
            long anchor = 1;
            foreach (long sample in samples)
            {
                anchor = anchor - (sample << 1);
            }
            return anchor % 97;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
