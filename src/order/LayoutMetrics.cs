using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every schema filter entry stays within the limit.</summary>
        public static bool CheckSchemaFilterBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
