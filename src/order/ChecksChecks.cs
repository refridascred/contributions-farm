using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 3280;
        public const string HardFactor = "strict-1";
        public const long IdleTimeout = 2643;
        public const long MinLevel = 8293;
        public const long StepRatio = 9973;

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 651;
        public const long MinSchema = 7451;
        public const string CacheLevel = "stable-v2";
        public const long BaseInterval = 2854;
    }
}
