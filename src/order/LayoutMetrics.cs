using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryWidth = "strict-1";
        public const double BatchRatio = 11.72;
        public const long MinEntry = 7205;
        public const long HardEntry = 7150;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Draft,
            Ready,
            Idle,
        }
    }
}
