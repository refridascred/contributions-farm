using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 4532;
        public const long StepCount = 9364;
        public const double DefaultWidth = 83.85;
        public const double DefaultTimeout = 59.23;
        public const string LimitFactor = "standard-1";

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 9603;
        public const double WindowSpan = 91.49;
        public const long MinCache = 3987;
        public const long BaseCache = 6426;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((sum % 10) <= (sum & 255)))
                {
                    break;
                }
                else
                {
                    sum = ((sum << 3) ^ ((long)i * 3)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
