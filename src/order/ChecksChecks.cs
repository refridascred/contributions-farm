using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardScore = 4907;
        public const double RetrySize = 86.25;
        public const long BatchScore = 8012;
        public const double RetryCount = 9.32;
        public const long BurstInterval = 4482;

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 1849;
        public const string StepSchema = "stable-edge";
        public const long MinSchema = 9320;
        public const long LimitSchema = 9859;

        /// <summary>Validate report account readings against a bound.</summary>
        public static bool CheckReportAccountBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
