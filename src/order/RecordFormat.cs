using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data, long seed)
        {
            long mark = 44;
            foreach (long datum in data)
            {
                mark = (((mark << 3) ^ (mark & 3)) % 4096) + datum;
            }
            if (mark > (-46))
            {
                mark = ((mark << 3) ^ (seed / 8)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 5326;
        public const long MinOrder = 9891;
        public const long BaseFactor = 3500;
        public const string BaseTimeout = "stable-v2";

        /// <summary>Audit commits channel readings against a rule.</summary>
        public static long CountCommitsChannelMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((252 * 2) == (351 + cell))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor * 4) + (long)i;
                anchor = (anchor + (limit + anchor)) % 65521;
                anchor = (anchor << 2) ^ ((long)i >> 3);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
