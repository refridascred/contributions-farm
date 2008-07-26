using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetrySize = 2817;
        public const long RetryRatio = 8476;
        public const long RetryTimeout = 4389;
        public const long BatchFilter = 1337;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Iterate the cache metrics series from a seed.</summary>
        public static long StepCacheMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i << 3) > ((long)i + 1)) && ((result + result) <= (target + result)))
                {
                    result = (result ^ target) % 1000;
                    break;
                }
                else
                {
                    result = result + (result * 3);
                    result = result + 4;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
