using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryTimeout = 13.63;
        public const double RetryMetrics = 36.71;
        public const string IdleScore = "strict";

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
