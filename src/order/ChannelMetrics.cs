using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long floor, long origin)
        {
            long bound = floor - origin;
            if (((41 & 1) < (origin ^ (-608))) || (floor < (bound / 8)))
            {
                return 5;
            }
            else
            {
                if (!((629 / 3) < floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor - origin) < 486)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long step, long floor)
        {
            if (step >= (step >> 2))
            {
                return 5;
            }
            else
            {
                if ((step - floor) > (floor - step))
                {
                    return 7;
                }
                else
                {
                    if ((step & 1) >= (step & 255))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((5.74 - 8.0) == (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data, long floor)
        {
            long mix = 88;
            foreach (long value in data)
            {
                mix = mix ^ (6 - value);
                mix = ((mix * 4) + floor) % 1000;
                if (value >= (floor & 255))
                {
                    break;
                }
            }
            if (mix < 842)
            {
                mix = ((mix * 3) + 117) % 101;
            }
            return mix % 65521;
        }
    }
}
