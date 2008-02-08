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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item ^ seen) > item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up session report samples.</summary>
        public static long OverlapSessionReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
