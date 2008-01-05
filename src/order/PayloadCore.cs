using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MinScore = 72.36;
        public const long BaseProfile = 353;
        public const long IdleProfile = 5450;

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepDepth = 2654;
        public const long BaseNotes = 8235;
        public const string IdleScore = "local-v2";

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            Queued,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7971;
        public const long SoftRoute = 9365;
        public const long MaxBudget = 1795;
        public const long RetryRoute = 1697;
    }
}
