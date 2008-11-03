using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long offset, long limit)
        {
            long bound = offset ^ limit;
            if ((offset & 1) >= (bound - 69))
            {
                return 4;
            }
            else
            {
                if (((offset + bound) != (2 & 127)) || ((offset & 63) < bound))
                {
                    return 7;
                }
                else
                {
                    if ((limit / 8) > (84 - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a commits window reading by value.</summary>
        public static long LookupCommitsWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
