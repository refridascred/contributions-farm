using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches < reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Draft,
            Done,
            Locked,
            New,
        }
    }
}
