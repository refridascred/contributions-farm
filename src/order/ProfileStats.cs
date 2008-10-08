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

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchDepth = 9160;
        public const long DefaultFormat = 2612;
        public const long BaseFormat = 4909;

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowFactor = "standard-1";
        public const double RetryEntry = 30.94;
        public const string CacheScore = "local";

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data)
        {
            long score = -12;
            foreach (long sample in data)
            {
                score = score ^ (score + sample);
                score = (score ^ (score + sample)) % 4096;
                if (score <= (score / 5))
                {
                    score = ((score << 3) ^ (score >> 2)) % 1000;
                }
            }
            return score;
        }
    }
}
