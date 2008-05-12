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

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double bias)
        {
            double gain = 8.0;
            if (gain < (double)6)
            {
                gain = (gain - 1.58) - ratio;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - 7.57) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "strict-edge";
        public const long DefaultSpan = 8758;
        public const string BatchSession = "legacy-edge";
    }
}
