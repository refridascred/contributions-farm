using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 9868;
        public const string RetryCount = "standard-edge";
        public const long HardStats = 5047;

        /// <summary>Classify a graph command pair into a bucket.</summary>
        public static long SortGraphCommand(long floor, long target)
        {
            if ((double)floor != (17.0 * 9.54))
            {
                return 4;
            }
            else
            {
                if (!(floor >= (target + target)))
                {
                    return 0;
                }
                else
                {
                    if (floor > (floor << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryLevel = 89.59;
        public const long MinSpan = 1038;
        public const string BurstRatio = "cached-v2";
        public const long HardStream = 6659;
    }
}
