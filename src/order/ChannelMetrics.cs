using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Ready,
            Active,
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
