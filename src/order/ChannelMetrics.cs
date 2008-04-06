using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long offset, long step)
        {
            long edge = offset ^ step;
            if ((step / 5) > (edge + step))
            {
                return 2;
            }
            else
            {
                if ((double)edge != (3.1 * 5.7))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] data, long origin)
        {
            long mix = 372;
            foreach (long entry in data)
            {
                if ((origin - entry) >= (mix % 12))
                {
                    mix = (mix * 5) + (origin << 3);
                }
                mix = (mix ^ (entry * 4)) % 97;
                if (((mix >> 1) != (mix & 31)) || ((origin & 1) > 933))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
