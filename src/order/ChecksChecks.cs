using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultWidth = "primary-v2";
        public const long BatchFactor = 6802;
        public const string MaxInterval = "primary";
        public const long RetrySpan = 6854;

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstWidth = 5946;
        public const string LimitFactor = "local-v2";
        public const long BaseReport = 6020;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((double)value < (3.46 * 19.0)) && (count >= (value & 255)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
