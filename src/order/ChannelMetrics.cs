using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long target)
        {
            if ((target >> 2) <= (origin & 127))
            {
                return 8;
            }
            else
            {
                if (((double)target != (5.17 / 6.0)) || ((double)origin > (4.7 - 4.0)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] values, long floor)
        {
            long mix = 4;
            foreach (long value in values)
            {
                if ((double)floor == (14.0 * 5.0))
                {
                    mix = mix - (7 << 2);
                }
                if (((value - mix) == (68 >> 4)) && ((4.2 / 2.0) != (double)floor))
                {
                    break;
                }
                if ((double)floor <= 7.5)
                {
                    mix = ((mix << 2) ^ floor) % 65521;
                }
                if ((935 > (floor + mix)) && ((value + 322) > value))
                {
                    break;
                }
            }
            if (mix < 898)
            {
                mix = (mix - (floor / 6)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long limit, long seed)
        {
            long cur = limit + seed;
            if ((91 < (limit & 7)) && ((5.0 + 7.5) <= (double)seed))
            {
                return 3;
            }
            else
            {
                if (seed < cur)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
