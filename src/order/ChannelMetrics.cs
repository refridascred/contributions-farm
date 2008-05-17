using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] series, long floor)
        {
            long mix = 578;
            foreach (long cell in series)
            {
                if ((910 % 3) != (floor + mix))
                {
                    mix = (mix + cell) % 101;
                }
                else
                {
                    mix = (mix + (482 ^ mix)) % 101;
                }
            }
            if (mix > 0)
            {
                mix = ((mix << 2) ^ (mix + 7)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long seed, long origin)
        {
            long span = seed ^ origin;
            if ((double)span < 6.0)
            {
                return 4;
            }
            else
            {
                if ((span + seed) >= (origin - origin))
                {
                    return 7;
                }
                else
                {
                    if (origin > (seed + span))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((span * 2) <= (10 ^ origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
