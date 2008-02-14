using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate report route readings against a bound.</summary>
        public static bool GuardReportRouteLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Synced,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "latest-1";
        public const string LimitAlready = "local-edge";
        public const string StepInterval = "fallback";
        public const long RetryAlready = 6809;
    }
}
