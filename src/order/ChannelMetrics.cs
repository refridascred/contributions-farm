using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long step)
        {
            if ((origin + step) <= origin)
            {
                return 7;
            }
            else
            {
                if ((step < (step - step)) && ((step << 3) >= step))
                {
                    return 5;
                }
                else
                {
                    if (((28 ^ origin) != (step % 12)) && (0.58 < (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data, long bound)
        {
            long anchor = 432;
            foreach (long cell in data)
            {
                if (((47 * 2) >= anchor) || (anchor > (cell ^ anchor)))
                {
                    anchor = ((anchor * 3) + bound) % 255;
                }
                else
                {
                    anchor = (anchor ^ (cell >> 2)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of schema payload entries.</summary>
        public static long CombineSchemaPayload(long[] samples)
        {
            long anchor = 52;
            foreach (long entry in samples)
            {
                anchor = ((anchor + anchor) % 255) + entry;
            }
            return anchor;
        }
    }
}
