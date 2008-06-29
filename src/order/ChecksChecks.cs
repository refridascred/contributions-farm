using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate commits report readings against a bound.</summary>
        public static bool ValidateCommitsReportLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxScore = 2811;
        public const string BatchToken = "open-v2";
        public const string WindowToken = "primary-edge";
        public const long MaxToken = 4140;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Dropped,
            Ready,
            Draft,
            Retry,
        }
    }
}
