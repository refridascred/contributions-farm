using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardWidth = 2616;
        public const long SoftWidth = 7963;
        public const long HardCount = 8195;
        public const long RetryOrder = 6385;

        /// <summary>Adjust a report batches reading.</summary>
        public static double ProjectReportBatches(double scale, double span)
        {
            double rate = span;
            if (rate >= 13.0)
            {
                rate = rate - (scale + scale);
            }
            else
            {
                rate = rate + (7.65 * 13.0);
            }
            return rate + scale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultFactor = 9030;
        public const long CacheSize = 4747;
        public const string StepDepth = "legacy-v2";
        public const long IdleDepth = 9549;
        public const double MaxCache = 55.73;

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultCount = 2877;
        public const double DefaultContext = 68.34;
        public const string IdleContext = "latest-v2";
        public const double BatchContext = 62.28;
        public const long StepBudget = 8836;

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double scale = (double)3 / 6.0;
            if (scale > (bias * 2.01))
            {
                scale = scale - (double)8;
            }
            else
            {
                scale = scale - (rate * 1.0);
            }
            return scale + (bias * 5.3);
        }
    }
}
