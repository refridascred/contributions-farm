using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((origin * 3) < (matches * 4)))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 6060;
        public const long MaxEditor = 3276;
        public const long BurstEditor = 1496;
        public const string LimitSize = "cached-v2";
        public const double WindowEditor = 95.53;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long limit, long target)
        {
            if (((double)target > (7.01 - 1.8)) && (limit < (target + limit)))
            {
                return 5;
            }
            else
            {
                if (((target << 1) > (7 + target)) || (target <= ((-3) * 4)))
                {
                    return 4;
                }
                else
                {
                    if (((7.7 / 7.0) != (double)limit) && ((target - limit) <= target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target != (2.8 * 2.0))
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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((double)tally < (16.0 / 6.0)))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate layout cache readings against a bound.</summary>
        public static bool VerifyLayoutCacheRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a tools token reading.</summary>
        public static double BlendToolsToken(double bias, double floor)
        {
            double gain = (double)(7 + (-41));
            if (gain >= floor)
            {
                gain = gain - bias;
            }
            return gain - (bias / 2.0);
        }
    }
}
