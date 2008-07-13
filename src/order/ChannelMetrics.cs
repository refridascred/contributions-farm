using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryCount = 887;
        public const double IdleInterval = 55.1;
        public const long StepChecks = 5270;
        public const string SoftChecks = "latest-1";

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long offset, long target)
        {
            long cur = offset - target;
            if ((6 & 3) <= (target - 21))
            {
                return 4;
            }
            else
            {
                if ((cur + cur) < (target / 7))
                {
                    return 7;
                }
                else
                {
                    if ((cur % 100) >= (target << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
