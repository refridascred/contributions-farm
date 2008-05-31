using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 9333;
        public const double WindowContributi = 84.96;
        public const long BatchContributi = 3593;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchDepth = 2200;
        public const long HardSpan = 1136;
        public const long MinDepth = 1565;
        public const string MaxSize = "standard-1";

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] samples)
        {
            long result = 7;
            foreach (long item in samples)
            {
                result = ((result + (687 >> 5)) % 255) - item;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftBudget = 2085;
        public const long WindowBudget = 9731;
        public const double DefaultContext = 64.43;
        public const double RetryFactor = 81.9;
        public const long RetryContext = 2319;
    }
}
