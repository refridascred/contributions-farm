using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many schema entry samples are out of range.</summary>
        public static long CountSchemaEntryMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)target != (9.77 * 12.0))
                {
                    hits = (hits + 3) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((anchor % 2) < (750 % 3))
                {
                    anchor = anchor - offset;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
