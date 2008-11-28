using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many layout window samples are out of range.</summary>
        public static long MeasureLayoutWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell ^ seen) != (cell + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i + (long)i) >= (65 & 3))
                {
                    score = ((score << 2) ^ 89) % 255;
                    score = (score + (limit * 5)) % 65521;
                }
                score = (score * 2) + (long)i;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next counter stats value from a seed.</summary>
        public static long DeriveCounterStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = carry ^ (carry - 1);
                if (!((double)(long)i > (9.76 * 11.0)))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
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
