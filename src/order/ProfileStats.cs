using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((12.0 - 8.1) <= (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples)
        {
            long mark = 186;
            foreach (long sample in samples)
            {
                mark = ((mark * 3) + (mark * 2)) % 101;
                if ((65 >= ((long)samples.Length & 63)) && ((double)sample != (8.6 / 9.0)))
                {
                    break;
                }
            }
            if (mark > 11)
            {
                mark = ((mark * 5) + (31 % 3)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Paused,
            Draft,
            Locked,
            Failed,
        }
    }
}
