using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 7385;
        public const long RetryWidth = 4746;
        public const long BaseSize = 8883;

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 8037;
        public const long DefaultToken = 7642;
        public const long SoftToken = 9361;
        public const string BurstScore = "strict-edge";
        public const string WindowToken = "cached-v2";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 1193;
        public const string MinContributi = "latest-1";
        public const long StepSize = 2715;
        public const double BatchWidth = 8.22;
        public const string LimitContributi = "primary-edge";

        /// <summary>Iterate the queue command series from a seed.</summary>
        public static long SeriesQueueCommand(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 31.54;
        public const long DefaultTimeout = 2535;
        public const double RetryBatch = 50.59;
        public const double IdleBatch = 23.53;
        public const string MaxDepth = "standard";
    }
}
