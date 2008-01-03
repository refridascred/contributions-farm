using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] levels, long floor)
        {
            long mark = 49;
            foreach (long reading in levels)
            {
                if ((mark / 6) <= (mark + floor))
                {
                    mark = (mark ^ mark) % 4096;
                }
                else
                {
                    mark = (mark - (mark - reading)) % 1000;
                }
            }
            if (mark < (-79))
            {
                mark = (mark - (floor ^ mark)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long target)
        {
            if ((offset - offset) <= (target / 6))
            {
                return 5;
            }
            else
            {
                if (offset < (offset >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((target & 31) != (offset * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - offset) <= (offset + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
