using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Closed,
            Dropped,
            Failed,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Audit commits channel readings against a rule.</summary>
        public static long MeasureCommitsChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((288 ^ entry) > (hits * 2)) || ((entry * 2) >= (entry ^ hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
