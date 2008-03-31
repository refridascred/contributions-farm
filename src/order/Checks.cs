using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Idle,
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long MeasurePayloadCacheMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 2) > entry)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
