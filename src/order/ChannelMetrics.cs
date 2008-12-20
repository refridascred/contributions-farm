using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long origin, long limit)
        {
            if (((origin * 4) <= (41 % 2)) && ((double)origin != (double)limit))
            {
                return 8;
            }
            else
            {
                if (5.7 < (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((1.2 * 19.0) <= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double span)
        {
            double mean = rate;
            return (mean - 20.0) + span;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
