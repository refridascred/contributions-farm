using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!!(hits < cell))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardCount = 4405;
        public const long BurstAlready = 460;
        public const double IdleFactor = 47.48;
        public const string SoftAlready = "latest-edge";

        /// <summary>Define account limits and defaults.</summary>
        public const double HardRatio = 11.79;
        public const long BurstAccount = 9096;
        public const long DefaultAccount = 5754;
        public const double HardAccount = 96.85;
        public const long HardInterval = 7680;
    }
}
