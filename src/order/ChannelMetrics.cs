using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 6916;
        public const long LimitSize = 2664;
        public const double BaseChecks = 31.54;
        public const long StepDepth = 7694;
        public const long BaseWidth = 8496;

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 63.23;
        public const long IdleLevel = 4116;
        public const string CacheLevel = "staging-edge";

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long offset2)
        {
            if ((395 + 742) < (offset2 ^ offset2))
            {
                return 5;
            }
            else
            {
                if ((offset2 - offset) >= (offset / 3))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
