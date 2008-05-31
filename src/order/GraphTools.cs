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

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double weight = (double)(67 * 3);
            if (weight < (double)546)
            {
                weight = weight - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight - weight;
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
