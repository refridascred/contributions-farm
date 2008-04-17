using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
