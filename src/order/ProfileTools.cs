using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((523 * 3) <= ((long)values.Length - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Closed,
            Draft,
            Idle,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            New,
            Ready,
            Done,
            Paused,
        }
    }
}
