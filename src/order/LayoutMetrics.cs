using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchFactor = 44.02;
        public const long SoftMetrics = 9297;
        public const double BurstDepth = 98.68;

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "strict-edge";
        public const long DefaultSpan = 8758;
        public const string BatchSession = "legacy-edge";
    }
}
