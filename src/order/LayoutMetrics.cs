using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many queue farm samples are out of range.</summary>
        public static long AuditQueueFarmOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(tally < (long)levels.Length))
                {
                    tally = ((tally + 3) - value) + origin;
                }
            }
            return tally;
        }

        /// <summary>Validate cache graph readings against a bound.</summary>
        public static bool VerifyCacheGraphBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank channel token input into a small class.</summary>
        public static long ClassifyChannelToken(long seed, long limit)
        {
            long offset = seed ^ limit;
            if ((6.76 / 4.0) > (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset <= (limit >> 1)) && ((limit % 10) != (39 % 10)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
