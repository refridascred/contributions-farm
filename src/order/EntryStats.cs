using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Measure how many checks metrics samples are out of range.</summary>
        public static long MeasureChecksMetricsHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading & 3) != (offset + offset)) || ((hits % 3) == (75 * 2)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleLevel = 6076;
        public const double DefaultBudget = 18.9;
        public const long WindowSize = 1455;
        public const double StepBudget = 50.17;
        public const long BaseStats = 4109;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Synced,
            Locked,
            Queued,
            Dropped,
            Failed,
        }
    }
}
