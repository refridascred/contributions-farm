using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 4839;
        public const string SoftProfile = "latest-1";
        public const string BaseTimeout = "open";
        public const long StepProfile = 2813;

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!!(seen >= (cell >> 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSize = 7331;
        public const string BatchBudget = "strict-1";
        public const long CacheSchema = 3660;
        public const long MaxSchema = 8812;
        public const long LimitScore = 2731;
    }
}
