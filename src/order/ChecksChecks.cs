using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 3544;
        public const string LimitEntry = "open-v2";
        public const string StepFactor = "staging-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 903;
        public const long BurstBatch = 1826;
        public const long HardInterval = 920;
        public const long StepWidth = 8788;
        public const long DefaultRatio = 8313;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
