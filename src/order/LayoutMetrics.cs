using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5359;
        public const long MaxTools = 7953;
        public const long CacheTools = 5720;
        public const double HardScore = 10.69;

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((0.71 * 6.39) <= (double)floor)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }
    }
}
