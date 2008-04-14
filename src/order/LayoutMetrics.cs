using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 7588;
        public const double IdleChecks = 75.14;
        public const long CacheDepth = 5872;
    }
}
