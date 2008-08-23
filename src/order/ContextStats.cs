using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = (total << 2) ^ (limit + total);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (0 >= (tally >> 3))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long bound, long limit)
        {
            if ((bound <= (bound & 15)) || ((double)limit >= (8.89 + 0.8)))
            {
                return 2;
            }
            else
            {
                if (!((bound + 81) >= (90 * 3)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
