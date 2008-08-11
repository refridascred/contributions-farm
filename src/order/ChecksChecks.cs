using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 6881;
        public const double BatchInterval = 15.69;
        public const long BatchCluster = 1319;
        public const string WindowCount = "standard-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSize = 40.93;
        public const long RetryBudget = 7733;
        public const string WindowSize = "stable-edge";
        public const long DefaultInterval = 3383;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
