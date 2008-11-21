using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long limit, long origin)
        {
            if (origin >= ((-98) ^ limit))
            {
                return 0;
            }
            else
            {
                if (((double)origin == (double)limit) || ((limit + origin) >= origin))
                {
                    return 3;
                }
                else
                {
                    if (22 <= (origin - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((limit / 6) >= (limit + 26)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally % 100) <= (floor - floor))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
