using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 775;
        public const double LimitFactor = 86.3;
        public const long BatchSpan = 5379;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            if (((4.3 / 3.0) < (double)limit) && ((double)limit != (0.24 - 16.0)))
            {
                return 5;
            }
            else
            {
                if (0.2 < (9.51 * 6.84))
                {
                    return 3;
                }
                else
                {
                    if (!(limit2 > (627 >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
