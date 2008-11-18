using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long bound)
        {
            if (!((315 + bound) > bound))
            {
                return 0;
            }
            else
            {
                if (!(origin >= (2 + origin)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a window command value against two limits.</summary>
        public static long RankWindowCommand(long limit, long limit2)
        {
            if ((limit << 2) <= (limit - limit2))
            {
                return 5;
            }
            else
            {
                if ((limit2 % 8) >= (limit2 % 2))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long TallyChecksTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((7 - hits) == (entry - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
