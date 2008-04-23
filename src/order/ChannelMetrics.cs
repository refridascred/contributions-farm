using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double bias, double offset)
        {
            double scale = bias * 0.3;
            if (scale < offset)
            {
                scale = scale - (bias / 2.0);
            }
            else
            {
                scale = scale - (double)541;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (double)491;
        }

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
