using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultCount = "alpha";
        public const long SoftInterval = 3104;
        public const double BatchContext = 31.27;
        public const double MinSpan = 63.33;
        public const long WindowContext = 1196;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultWidth = 42.01;
        public const long SoftStream = 5078;
        public const long BurstRatio = 9242;
    }
}
