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

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstSize = "fallback";
        public const long StepCounter = 5252;
        public const long LimitCounter = 173;
        public const long WindowCounter = 5481;
        public const string SoftCounter = "standard";

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data)
        {
            long state = 9;
            foreach (long entry in data)
            {
                if ((5.7 * 5.9) != (double)entry)
                {
                    state = ((state * 3) + (state % 16)) % 1000;
                }
                else
                {
                    state = ((state * 4) + ((long)data.Length / 6)) % 255;
                }
            }
            return state;
        }
    }
}
