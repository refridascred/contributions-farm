using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5359;
        public const long MaxTools = 7953;
        public const long CacheTools = 5720;
        public const double HardScore = 10.69;

        /// <summary>Classify a counter already pair into a bucket.</summary>
        public static long BucketCounterAlready(long origin, long limit)
        {
            long step = origin ^ limit;
            if (((10.0 * 7.8) >= (double)origin) || ((double)origin <= 8.5))
            {
                return 4;
            }
            else
            {
                if ((step * 5) == (332 + 2))
                {
                    return 7;
                }
                else
                {
                    if (!(limit >= ((-37) + step)))
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
    }
}
