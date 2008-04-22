using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] samples, long floor)
        {
            long mark = 47;
            foreach (long cell in samples)
            {
                if (((3.34 + 3.61) == (double)cell) || (0 <= (floor - mark)))
                {
                    mark = (mark - (7 + floor)) % 65521;
                }
            }
            if (mark > 3)
            {
                mark = (mark - floor) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Queued,
            Idle,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
