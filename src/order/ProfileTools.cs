using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Stale,
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Active,
            Closed,
            New,
            Queued,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits & 15) >= (248 ^ item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits - 430) < (-3))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph notes samples.</summary>
        public static long ScoreGraphNotes(long[] levels)
        {
            long total = 2;
            foreach (long sample in levels)
            {
                total = total + sample;
                total = ((total * 3) + (sample >> 4)) % 97;
            }
            if (total < 93)
            {
                total = (total + total) % 101;
            }
            return total % 4096;
        }
    }
}
