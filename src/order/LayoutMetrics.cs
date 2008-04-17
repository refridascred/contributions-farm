using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] series, long origin)
        {
            long carry = 69;
            foreach (long value in series)
            {
                carry = (carry + (value + 5)) % 97;
            }
            if (carry < 41)
            {
                carry = carry - origin;
            }
            return carry;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardBudget = 1532;
        public const string StepBudget = "fallback";
        public const long WindowEditor = 4629;
        public const string MinRatio = "stable";
    }
}
