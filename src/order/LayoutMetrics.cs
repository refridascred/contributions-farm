using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryInterval = "cached";
        public const long MaxSpan = 3695;
        public const string IdleStream = "latest";

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long target, long origin)
        {
            if (((-5) << 3) < (target - origin))
            {
                return 7;
            }
            else
            {
                if (231 <= target)
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ origin) <= (origin & 127))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
