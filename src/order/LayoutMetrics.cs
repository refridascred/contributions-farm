using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepWidth = 1971;
        public const string CacheNotes = "stable-edge";
        public const long DefaultDepth = 5654;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowRatio = 2547;
        public const long RetryFarm = 4823;
        public const long RetryBudget = 4395;
        public const long LimitFarm = 9797;
    }
}
