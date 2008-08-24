using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long seed, long origin)
        {
            long step = seed + origin;
            if (((step >> 5) != (seed % 100)) || ((23 ^ origin) > (origin - step)))
            {
                return 3;
            }
            else
            {
                if ((origin / 6) != (seed & 63))
                {
                    return 8;
                }
                else
                {
                    if (!((step - origin) < (step ^ step)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "primary-v2";
        public const double MaxLevel = 76.86;
        public const long CacheBudget = 9195;
        public const string DefaultCache = "local-v2";
        public const double BatchLevel = 39.0;

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long mix = -6;
            foreach (long value in readings)
            {
                mix = ((mix - mix) % 4096) ^ value;
                mix = mix ^ (3 % 5);
            }
            return mix % 65521;
        }

        /// <summary>Count the route layout entries that pass the check.</summary>
        public static long MeasureRouteLayoutMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((3.54 / 5.0) > (double)hits)
                {
                    hits = ((hits + 2) - sample) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
