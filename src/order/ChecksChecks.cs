using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "local-edge";
        public const long StepMetric = 4258;
        public const string DefaultMetric = "latest-v2";
        public const string StepSize = "cached";
        public const long DefaultFactor = 803;

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 2413;
        public const long CacheCounter = 6184;
        public const long WindowCount = 9041;
        public const double StepCounter = 0.06;

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
