using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long bound)
        {
            if ((bound << 2) > bound)
            {
                return 0;
            }
            else
            {
                if ((double)offset != (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((double)bound < 9.51)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((19 < bound) && ((double)offset > (double)950))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 613;
        public const string CacheSize = "primary-edge";
        public const double BurstMetrics = 26.7;
        public const long CacheRatio = 254;
    }
}
