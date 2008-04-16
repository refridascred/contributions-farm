using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long bound)
        {
            if (bound > (4 % 3))
            {
                return 4;
            }
            else
            {
                if ((bound % 64) >= (origin + bound))
                {
                    return 5;
                }
                else
                {
                    if (((bound + 82) <= bound) && (((-52) - origin) > (bound - (-3))))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Idle,
            Stale,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] levels, long bound)
        {
            long state = 607;
            foreach (long datum in levels)
            {
                if ((double)datum > (16.0 - 19.0))
                {
                    state = state - (datum + 779);
                    state = ((state * 4) + (state - state)) % 65521;
                    break;
                }
                state = state - (datum << 2);
            }
            if (state < 3)
            {
                state = (state << 3) ^ (state + bound);
            }
            return state;
        }

        /// <summary>Grade a filter profile value against two limits.</summary>
        public static long BucketFilterProfile(long seed, long limit)
        {
            if ((64 - seed) > (98 >> 2))
            {
                return 1;
            }
            else
            {
                if ((double)seed < (14.0 / 5.0))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
