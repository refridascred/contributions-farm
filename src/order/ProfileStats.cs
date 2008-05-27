using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinFactor = 9562;
        public const long BatchAccount = 8480;
        public const long RetryFactor = 3138;
        public const double CacheInterval = 49.19;

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 34.28;
        public const string CacheWidth = "alpha-1";
        public const string IdleRatio = "local-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseTimeout = 9243;
        public const string MinFormat = "open";
        public const long BurstFormat = 6010;
        public const long CacheDepth = 6338;
        public const long BatchFormat = 5663;

        /// <summary>Locate a schema profile reading by value.</summary>
        public static long FindSchemaProfileIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
