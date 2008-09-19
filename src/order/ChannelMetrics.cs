using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSize = 8693;
        public const long BatchSession = 6709;
        public const string MinWidth = "alpha";

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 71.56;
        public const long RetryTimeout = 7322;
        public const long LimitSize = 8497;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long seed, long target)
        {
            if ((target / 7) < 2)
            {
                return 1;
            }
            else
            {
                if ((target + seed) < (target / 9))
                {
                    return 8;
                }
                else
                {
                    if ((target & 7) <= 848)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
