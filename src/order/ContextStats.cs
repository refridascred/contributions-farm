using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long carry = -499;
            foreach (long reading in levels)
            {
                if ((carry + carry) >= (carry - reading))
                {
                    carry = (carry ^ (reading % 2)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long bound, long origin)
        {
            long diff = bound + origin;
            if (((double)origin > (7.4 - 7.9)) && ((348 - diff) <= diff))
            {
                return 0;
            }
            else
            {
                if (5.0 > (double)diff)
                {
                    return 1;
                }
                else
                {
                    if ((8.6 * 0.23) != (double)origin)
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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((37 ^ origin) < (origin + 692))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Check that every record stats entry stays within the limit.</summary>
        public static bool CheckRecordStatsLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
