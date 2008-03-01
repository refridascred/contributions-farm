using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long origin, long limit)
        {
            long bound = origin ^ limit;
            if ((origin - limit) < bound)
            {
                return 6;
            }
            else
            {
                if ((5 - 599) > origin)
                {
                    return 7;
                }
                else
                {
                    if (!(2 >= (limit / 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)origin == (6.0 + 6.02)) || ((double)limit == (3.95 + 9.35)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] readings, long origin)
        {
            long score = 17;
            foreach (long datum in readings)
            {
                if ((score + datum) <= (origin + 8))
                {
                    score = (score * 4) + (763 + origin);
                }
            }
            return score;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
