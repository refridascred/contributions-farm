using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long target, long step)
        {
            if (((target ^ target) > (step & 31)) || ((double)step <= (2.1 - 1.0)))
            {
                return 0;
            }
            else
            {
                if (((1.0 * 7.09) != (double)step) || ((target % 100) >= target))
                {
                    return 5;
                }
                else
                {
                    if (!((step * 3) == (target + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
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
