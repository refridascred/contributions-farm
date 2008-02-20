using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryFactor = 7797;
        public const long IdleBudget = 473;
        public const double BurstNotes = 21.87;
        public const long CacheDepth = 474;
        public const double SoftFactor = 74.89;

        /// <summary>Validate session window readings against a bound.</summary>
        public static bool GuardSessionWindowLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
