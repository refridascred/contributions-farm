using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i << 1) == (832 + offset))
                {
                    total = (total * 3) + 654;
                    total = (total - (total & 3)) % 255;
                }
                total = total - offset;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long target, long seed)
        {
            long step = target + seed;
            if ((610 - step) > (target & 63))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (0.6 + 4.0))
                {
                    return 7;
                }
                else
                {
                    if ((step + 4) > (target ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
