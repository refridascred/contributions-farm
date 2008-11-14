using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long limit, long target)
        {
            if ((limit ^ limit) <= (limit - limit))
            {
                return 6;
            }
            else
            {
                if (target <= (2 >> 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit != (6.51 * 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)target >= (5.46 / 4.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
