using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 4902;
        public const long HardPayload = 1475;
        public const string BatchScore = "fallback-edge";
        public const long WindowLevel = 4041;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowFactor = "standard-1";
        public const double RetryEntry = 30.94;
        public const string CacheScore = "local";

        /// <summary>Audit cluster contributi readings against a rule.</summary>
        public static long MeasureClusterContributiMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!!((hits / 3) >= (447 % 64)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }
    }
}
