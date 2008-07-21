using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of cache batches readings.</summary>
        public static long ScoreCacheBatches(long[] series, long seed)
        {
            long total = 397;
            foreach (long value in series)
            {
                total = ((total - (total * 4)) + value) - seed;
            }
            return total;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long origin)
        {
            if (((0.3 + 8.0) < (double)limit) || ((origin << 2) <= (limit + limit)))
            {
                return 2;
            }
            else
            {
                if (origin > (limit - limit))
                {
                    return 3;
                }
                else
                {
                    if ((8.0 / 7.0) >= (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((6.1 * 0.97) == (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 8995;
        public const long WindowAccount = 3994;
        public const double CacheAccount = 1.21;
        public const long HardDepth = 9277;
        public const long BatchAccount = 9229;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Failed,
            Active,
        }
    }
}
