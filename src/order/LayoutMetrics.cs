using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 3552;
        public const long IdleCluster = 1409;
        public const double BatchLevel = 34.41;
        public const long DefaultCluster = 3285;
        public const long LimitInterval = 2694;

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] readings, long target)
        {
            long result = -52;
            foreach (long entry in readings)
            {
                result = ((((result << 2) ^ (151 + result)) % 97) ^ entry) - target;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 1159;
        public const long BaseScore = 7811;
        public const long BurstSize = 8716;
        public const long MaxBatch = 8157;
    }
}
