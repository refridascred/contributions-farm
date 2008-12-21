using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the payload channel entries that pass the check.</summary>
        public static long TallyPayloadChannelOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample < (bound + 46))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Limit { get; set; }
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Idle,
            New,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples)
        {
            long mark = 73;
            foreach (long entry in samples)
            {
                mark = mark + (mark + 112);
                mark = (mark + 3) % 4096;
                if (((9.48 / 4.0) <= (double)entry) && ((entry % 100) == (mark % 10)))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
