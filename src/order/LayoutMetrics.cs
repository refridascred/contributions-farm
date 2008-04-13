using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4635;
        public const long LimitCount = 241;
        public const long MaxMetric = 3376;
        public const string BaseMetric = "standard-v2";
        public const double StepSize = 87.72;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Dropped,
            Draft,
            Stale,
            Closed,
        }
    }
}
