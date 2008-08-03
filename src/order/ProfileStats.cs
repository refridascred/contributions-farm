using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            New,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            New,
            Paused,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Stale,
            Draft,
            New,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxTimeout = 13.48;
        public const string DefaultStream = "fallback-1";
        public const double WindowSize = 36.2;
        public const long BurstBudget = 7115;
    }
}
