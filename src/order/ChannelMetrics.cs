using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a stream context pair into a bucket.</summary>
        public static long RankStreamContext(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if ((bound2 + bound2) >= bound2)
            {
                return 7;
            }
            else
            {
                if ((step + bound2) < (bound + bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)step > (1.44 / 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((31 >> 3) >= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a payload filter reading.</summary>
        public static double ProjectPayloadFilter(double bias, double bias2)
        {
            double bias3 = bias2 * 1.92;
            if (bias3 < (bias / 2.0))
            {
                bias3 = bias3 + bias3;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 + (bias + 0.2)) + (double)(long)i;
            }
            return bias3 + bias;
        }
    }
}
