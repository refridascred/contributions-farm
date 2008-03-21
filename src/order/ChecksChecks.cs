using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 5413;
        public const long HardFactor = 6645;
        public const long MaxQueue = 8573;
        public const double StepBudget = 51.67;

        /// <summary>Validate report farm readings against a bound.</summary>
        public static bool ValidateReportFarmRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
