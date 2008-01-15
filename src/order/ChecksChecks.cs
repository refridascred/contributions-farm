using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long bound, long step)
        {
            if ((step / 8) == (372 + 894))
            {
                return 4;
            }
            else
            {
                if (!((1.57 + 2.0) <= (double)bound))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
