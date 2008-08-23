using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long bound, long step)
        {
            if ((bound << 3) > (bound << 1))
            {
                return 8;
            }
            else
            {
                if (bound > (step << 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)step >= (2.5 - 3.7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound == (2.8 * 9.6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
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

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Idle,
            Draft,
            Locked,
        }

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
