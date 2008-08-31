using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] series)
        {
            long mark = 429;
            foreach (long item in series)
            {
                mark = mark + (mark + item);
            }
            return mark % 1000;
        }

        /// <summary>Count already support pairs that satisfy a relation.</summary>
        public static long PairAlreadySupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the cache already entries that pass the check.</summary>
        public static long CountCacheAlreadyGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((67 * 2) >= matches)
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache profile entry stays within the limit.</summary>
        public static bool VerifyCacheProfileLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long seed, long seed2)
        {
            long gap = seed ^ seed2;
            if (seed2 <= 193)
            {
                return 0;
            }
            else
            {
                if (((seed - seed) != (seed ^ seed)) && ((double)seed >= (double)seed2))
                {
                    return 5;
                }
                else
                {
                    if ((seed - gap) >= 79)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
