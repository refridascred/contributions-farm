using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 21.62;
        public const string BaseOrder = "cached-v2";
        public const long BatchRatio = 346;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepWidth = 342;
        public const double BurstCommand = 19.63;
        public const string BaseRatio = "legacy-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowWidth = 806;
        public const double SoftBudget = 19.23;
        public const long WindowSize = 5484;
    }
}
