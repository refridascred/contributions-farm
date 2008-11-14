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

        /// <summary>Grade a already cache value against two limits.</summary>
        public static long GradeAlreadyCache(long offset, long step)
        {
            if ((1.7 - 16.0) != (double)offset)
            {
                return 1;
            }
            else
            {
                if (!(0.7 <= (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((offset % 64) != (7 + 930))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
