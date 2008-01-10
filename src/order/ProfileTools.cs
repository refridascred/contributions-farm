using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 6024;
        public const string RetryWidth = "standard-v2";
        public const long MinRatio = 8683;

        /// <summary>Rank filter queue input into a small class.</summary>
        public static long RankFilterQueue(long limit, long origin)
        {
            if (((origin + origin) > origin) || ((limit - origin) < 815))
            {
                return 2;
            }
            else
            {
                if ((double)origin == (8.9 - 9.37))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardSize = 70.39;
        public const double RetryContext = 70.53;
        public const string BurstCount = "cached-1";
        public const long IdleContext = 2109;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
