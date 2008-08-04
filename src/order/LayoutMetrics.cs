using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (origin - (long)i)) % 4096;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitScore = "legacy-1";
        public const double DefaultPayload = 54.55;
        public const double BaseScore = 37.1;
        public const string RetryPayload = "staging-1";
        public const long CacheWidth = 4802;

        /// <summary>Define session limits and defaults.</summary>
        public const long MinDepth = 5693;
        public const long CacheRatio = 5302;
        public const long BaseCount = 6607;
        public const long MinRatio = 2570;
    }
}
