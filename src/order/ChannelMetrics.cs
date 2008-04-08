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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches < (double)entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
