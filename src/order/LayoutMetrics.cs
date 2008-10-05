using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheWidth = 4232;
        public const string DefaultMetric = "local-v2";
        public const string WindowMetric = "strict-v2";
        public const double IdleMetric = 17.38;

        /// <summary>Count report graph pairs that satisfy a relation.</summary>
        public static long CompareReportGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double scale, double bias)
        {
            double rate = scale;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + scale) + (double)(long)i) + bias;
            }
            return rate - (rate * 1.0);
        }
    }
}
