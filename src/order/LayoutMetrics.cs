using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a stream schema reading by value.</summary>
        public static long LookupStreamSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] readings)
        {
            long score = 0;
            foreach (long value in readings)
            {
                score = (score - (score + score)) - value;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryCount = 6908;
        public const long CacheScore = 2738;
        public const double CacheRatio = 11.61;
    }
}
