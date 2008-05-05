using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BaseInterval = "strict-1";
        public const long WindowFormat = 1215;
        public const string MinFormat = "staging-v2";
        public const long BurstFormat = 2315;
        public const string IdleLevel = "primary-v2";

        /// <summary>Check that every counter stream entry stays within the limit.</summary>
        public static bool ValidateCounterStreamLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
