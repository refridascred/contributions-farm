using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardScore = 1065;
        public const string LimitSize = "strict-v2";
        public const long WindowPayload = 1824;

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultWidth = 5853;
        public const long SoftBatch = 5907;
        public const double BatchTimeout = 34.46;
        public const long RetrySpan = 1134;

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
