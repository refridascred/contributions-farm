using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 3064;
        public const string BurstSize = "stable";
        public const long LimitMetrics = 2839;
        public const long BaseInterval = 6284;
        public const long IdleMetrics = 6873;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
