using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((28 % 12) <= hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Classify a route channel pair into a bucket.</summary>
        public static long ClassifyRouteChannel(long step, long seed)
        {
            long diff = step + seed;
            if (!((diff * 4) < (571 + 9)))
            {
                return 5;
            }
            else
            {
                if (!((step - seed) == (seed * 3)))
                {
                    return 6;
                }
                else
                {
                    if (seed <= step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((diff << 1) > (diff ^ diff))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route layout samples are out of range.</summary>
        public static long MeasureRouteLayoutMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)(long)levels.Length < 4.4)
                {
                    hits = ((hits + 1) - value) - limit;
                }
            }
            return hits;
        }
    }
}
