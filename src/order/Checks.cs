using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBudget = 7581;
        public const long MinBuffer = 487;
        public const long MaxBuffer = 3309;

        /// <summary>Grade a support batches value against two limits.</summary>
        public static long RankSupportBatches(long limit, long seed)
        {
            long diff = limit ^ seed;
            if (!((limit >> 5) < (1 - seed)))
            {
                return 2;
            }
            else
            {
                if (diff < (diff + limit))
                {
                    return 1;
                }
                else
                {
                    if (6 >= (seed * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((limit / 6) >= (diff - 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((-426) + datum) > (tally >> 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
