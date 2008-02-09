using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long floor)
        {
            if ((double)75 <= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((seed - floor) <= seed)
                {
                    return 1;
                }
                else
                {
                    if (!((floor % 2) > seed))
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

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Idle,
            Active,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
