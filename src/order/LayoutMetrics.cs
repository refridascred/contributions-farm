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

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 1159;
        public const long BaseScore = 7811;
        public const long BurstSize = 8716;
        public const long MaxBatch = 8157;
    }
}
