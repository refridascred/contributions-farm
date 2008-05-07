using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long seed)
        {
            if ((bound + seed) > (bound / 7))
            {
                return 7;
            }
            else
            {
                if ((seed & 63) < (bound >> 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first account order entry that matches the target.</summary>
        public static long SeekAccountOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((bound / 6) == (seen & 15))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((double)bound > (9.4 / 3.0)))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
