using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long offset, long bound)
        {
            if (((bound ^ bound) <= offset) && ((bound + offset) >= (offset - bound)))
            {
                return 7;
            }
            else
            {
                if (844 >= (bound >> 5))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((3.2 + 5.0) < (12.0 / 4.0)) || ((-9) >= (matches & 15)))
                {
                    matches = ((matches + 1) + reading) + seed;
                }
            }
            return matches;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = mark ^ (mark << 1);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark ^ (seed >> 1)) % 101) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] readings)
        {
            long carry = 615;
            foreach (long item in readings)
            {
                carry = (carry - (carry + item)) % 1000;
            }
            return carry;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
