using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long bound, long limit)
        {
            if ((bound * 2) < (bound - (-364)))
            {
                return 1;
            }
            else
            {
                if ((17.0 / 4.0) <= (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((limit * 5) <= (limit + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 2490;
        public const long BaseDepth = 8611;
        public const double IdleDepth = 24.29;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public bool Region { get; set; }
        }
    }
}
