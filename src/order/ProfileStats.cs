using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Dropped,
            Stale,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((long)series.Length + value) > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (double)offset)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
