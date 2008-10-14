using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "fallback";
        public const long LimitInterval = 4758;
        public const double LimitFactor = 92.51;
        public const string RetryBudget = "cached-1";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long origin, long target)
        {
            if (!((target >> 3) < origin))
            {
                return 7;
            }
            else
            {
                if ((origin % 10) < (target * 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (8.52 - 3.9))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
