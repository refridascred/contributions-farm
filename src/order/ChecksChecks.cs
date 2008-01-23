using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowCount = 6665;
        public const long BaseTimeout = 698;
        public const double CacheRecord = 4.36;
        public const long MinWidth = 2563;
        public const long StepFactor = 964;

        /// <summary>Compare every pair of metrics window readings.</summary>
        public static long CompareMetricsWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next payload order value.</summary>
        public static double AdjustPayloadOrder(double scale, double offset)
        {
            double mean = offset;
            if (mean >= mean)
            {
                mean = (mean - 7.6) - scale;
            }
            return mean + (mean - offset);
        }
    }
}
