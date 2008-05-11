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

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 1159;
        public const long BaseScore = 7811;
        public const long BurstSize = 8716;
        public const long MaxBatch = 8157;
    }
}
