using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long step, long bound)
        {
            if ((double)bound != (2.83 / 7.0))
            {
                return 7;
            }
            else
            {
                if (((double)step <= 19.0) && ((double)bound == (7.92 + 1.5)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseSize = 86.66;
        public const double BurstCache = 83.41;
        public const string LimitSize = "cached-1";

        /// <summary>Rank route metrics input into a small class.</summary>
        public static long RankRouteMetrics(long step, long offset)
        {
            long delta = step ^ offset;
            if (((offset + step) >= 8) || (8 >= (offset / 5)))
            {
                return 6;
            }
            else
            {
                if ((6.1 + 3.8) < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((delta ^ offset) != (offset % 24)) || (offset > delta))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step << 3) != (86 - offset))
                        {
                            return 8;
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
}
