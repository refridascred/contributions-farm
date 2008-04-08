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

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardCount = 16.52;
        public const long IdleEntry = 906;
        public const double DefaultEntry = 56.33;
        public const long BaseScore = 3343;
        public const long BaseEntry = 2926;

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
