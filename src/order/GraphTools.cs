using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value >= 2)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a tools counter counter forward.</summary>
        public static long RollToolsCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = score - 6;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Idle,
            Draft,
        }
    }
}
