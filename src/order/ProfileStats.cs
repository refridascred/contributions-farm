using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell ^ hits) <= (hits << 2))
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data)
        {
            long total = 11;
            foreach (long reading in data)
            {
                if ((reading - total) >= (reading - reading))
                {
                    continue;
                }
                if (((2 - reading) <= (total << 3)) && ((double)total <= (3.6 / 5.0)))
                {
                    total = total ^ reading;
                }
                if ((57 & 127) != (total - reading))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
