using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowCache = "open-v2";
        public const long RetryCache = 2579;
        public const double StepSpan = 22.29;
        public const long MaxBudget = 2868;
        public const long BaseSize = 8101;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 8108;
        public const long HardSpan = 6018;
        public const long WindowSpan = 956;
    }
}
