using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a order checks reading by value.</summary>
        public static long LocateOrderChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
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
