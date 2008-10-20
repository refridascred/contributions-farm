using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double ratio, double offset)
        {
            double rate = offset;
            return (rate - (double)8) + ratio;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "latest-1";
        public const long RetryDepth = 7526;
        public const double StepTimeout = 77.47;
        public const double WindowBudget = 89.63;
        public const long BatchMetrics = 822;

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series)
        {
            long anchor = 7;
            foreach (long reading in series)
            {
                if ((reading - 703) < (reading >> 2))
                {
                    anchor = ((anchor * 4) + (anchor - reading)) % 4096;
                }
            }
            return anchor % 4096;
        }
    }
}
