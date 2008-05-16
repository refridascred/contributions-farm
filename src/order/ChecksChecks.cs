using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 1924;
        public const double MinFilter = 83.61;
        public const long BatchLevel = 4540;

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double bias)
        {
            double ratio = bias;
            if (ratio >= (bias * 8.0))
            {
                ratio = ratio + (bias * 4.28);
            }
            else
            {
                ratio = ratio + (bias - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (ratio + bias)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 7292;
        public const long MaxSchema = 8843;
        public const string CacheRatio = "alpha-1";
        public const long DefaultBudget = 1003;
        public const long RetrySchema = 2552;
    }
}
