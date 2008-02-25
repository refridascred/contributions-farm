using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a stats session value against two limits.</summary>
        public static long RankStatsSession(long bound, long seed)
        {
            if ((seed <= (seed - bound)) || ((double)seed <= (20.0 * 14.0)))
            {
                return 0;
            }
            else
            {
                if ((5.77 - 7.7) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((-12) + seed) >= (seed + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (4 < seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
