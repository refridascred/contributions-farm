using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MaxBudget = "staging-1";
        public const string LimitFactor = "primary-v2";
        public const string BatchSpan = "cached-v2";

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Active,
            Stale,
            Done,
        }

        /// <summary>Validate graph layout readings against a bound.</summary>
        public static bool VerifyGraphLayoutLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
