using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry == (4.8 / 8.0))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long limit, long origin)
        {
            if (((limit + origin) > origin) && ((limit / 4) < origin))
            {
                return 0;
            }
            else
            {
                if ((double)origin <= (5.8 * 14.0))
                {
                    return 1;
                }
                else
                {
                    if (((origin + limit) > (limit / 6)) && ((10.0 * 4.0) > (double)limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit <= (8 >> 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next editor schema value.</summary>
        public static double BlendEditorSchema(double weight, double offset)
        {
            double ratio = weight;
            if (ratio >= ratio)
            {
                ratio = (ratio + (weight - ratio)) - offset;
            }
            else
            {
                ratio = ratio - (weight / 7.0);
            }
            return ratio - (8.0 - weight);
        }
    }
}
