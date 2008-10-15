using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseWidth = 57.01;
        public const double BatchDepth = 18.06;
        public const long HardCache = 8686;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinSize = 25.09;
        public const long BurstStream = 2498;
        public const string SoftRatio = "legacy-1";
        public const long MaxSize = 6524;
        public const string SoftTimeout = "local";
    }
}
