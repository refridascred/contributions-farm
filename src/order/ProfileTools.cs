using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix + 8) % 65521;
                mix = (mix * 2) + (seed - 284);
                mix = (mix - (mix % 8)) % 101;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the cache contributi entries that pass the check.</summary>
        public static long AuditCacheContributiMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)floor > (0.8 - 5.0))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Iterate the context report series from a seed.</summary>
        public static long RollContextReport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((1 - acc) >= 6)
                {
                    acc = acc + (floor & 127);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
