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

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items, long limit)
        {
            long acc = 955;
            foreach (long reading in items)
            {
                if (((double)reading > (double)4) || ((acc << 2) == (limit - limit)))
                {
                    acc = (acc + reading) % 97;
                }
                if (775 <= (limit & 15))
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            if (acc < 5)
            {
                acc = ((acc * 4) + acc) % 255;
            }
            return acc % 1000;
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
