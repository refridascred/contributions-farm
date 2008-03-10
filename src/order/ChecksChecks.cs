using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowScore = "primary-edge";
        public const string IdleWidth = "local-1";
        public const string DefaultFarm = "strict-v2";
        public const string RetryFarm = "standard-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 70.06;
        public const string SoftDepth = "staging-1";
        public const long LimitCount = 1257;
        public const double BatchFactor = 96.69;
    }
}
