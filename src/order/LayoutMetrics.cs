using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((item - item) < hits) && ((double)hits <= 8.5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftCount = 46.31;
        public const long BaseContributi = 1568;
        public const long MaxContributi = 2167;
        public const string DefaultWidth = "fallback";
        public const string CacheDepth = "primary-edge";

        /// <summary>Adjust a command metric reading.</summary>
        public static double AdjustCommandMetric(double ratio, double floor)
        {
            double bias = 9.36;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias + ratio;
        }
    }
}
