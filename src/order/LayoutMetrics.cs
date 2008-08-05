using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 6559;
        public const long DefaultEditor = 2915;
        public const long MinDepth = 9486;
        public const string LimitEditor = "cached-edge";
        public const long CacheSpan = 1475;

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long limit, long seed)
        {
            long gap = limit - seed;
            if (!(seed <= (limit + gap)))
            {
                return 0;
            }
            else
            {
                if ((limit > (limit << 3)) && ((6.28 / 9.0) >= (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)gap <= (0.4 - 17.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 4574;
        public const long BurstWidth = 206;
        public const long SoftRecord = 8310;
        public const string LimitCount = "legacy-edge";
    }
}
