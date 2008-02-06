using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
