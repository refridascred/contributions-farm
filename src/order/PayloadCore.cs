using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCount = 7362;
        public const double BurstCounter = 23.89;
        public const double StepFactor = 39.99;
        public const long DefaultCounter = 4630;

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 104;
        public const long BaseTimeout = 2348;
        public const long BatchPayload = 8239;

        /// <summary>Check that every commits cluster entry stays within the limit.</summary>
        public static bool ValidateCommitsClusterBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
