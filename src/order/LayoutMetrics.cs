using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate graph metric readings against a bound.</summary>
        public static bool ValidateGraphMetricRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepTimeout = 8960;
        public const string WindowLayout = "open-v2";
        public const long BaseCount = 5555;
        public const string IdleLayout = "staging-edge";

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Queued,
            Locked,
            New,
            Draft,
        }
    }
}
