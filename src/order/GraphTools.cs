using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many batch contributi samples are out of range.</summary>
        public static long AuditBatchContributiOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (51 >= tally)
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Synced,
            Queued,
            Closed,
            Done,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
