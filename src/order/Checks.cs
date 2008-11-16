using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support format readings against a bound.</summary>
        public static bool CheckSupportFormatBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long target, long origin)
        {
            if (!((18.0 * 9.81) < (double)origin))
            {
                return 6;
            }
            else
            {
                if ((origin - origin) == (origin ^ 46))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a route report value against two limits.</summary>
        public static long ClassifyRouteReport(long offset, long floor)
        {
            if (!((double)offset < (8.22 / 3.0)))
            {
                return 0;
            }
            else
            {
                if ((double)floor != (double)787)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
