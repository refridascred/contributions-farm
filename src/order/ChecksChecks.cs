using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate farm commits readings against a bound.</summary>
        public static bool VerifyFarmCommitsRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 8973;
        public const string WindowCount = "stable-edge";
        public const string BatchWindow = "latest";
        public const string BaseWindow = "cached-edge";

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 8554;
        public const string MinContext = "fallback-edge";
        public const string DefaultLevel = "legacy-v2";
    }
}
