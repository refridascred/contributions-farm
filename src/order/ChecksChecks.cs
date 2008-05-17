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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseTimeout = "staging-edge";
        public const long BatchBuffer = 2375;
        public const long BaseCount = 1011;
        public const double BatchRatio = 61.16;
        public const long BurstBuffer = 8841;

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] values, long floor)
        {
            long total = -7;
            foreach (long sample in values)
            {
                if (((20.0 / 8.0) >= (double)floor) && ((double)total <= (double)floor))
                {
                    total = (total + (sample / 3)) % 1000;
                }
                if ((sample - floor) != (floor / 4))
                {
                    total = total + (floor - 4);
                }
                if ((6 - total) > (sample - sample))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
