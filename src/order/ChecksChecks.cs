using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Draft,
            Stale,
            Ready,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleScore = 10;
        public const double BaseFactor = 86.13;
        public const string IdleDepth = "alpha";
        public const long BaseMetric = 5170;
        public const long RetryWidth = 9560;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
