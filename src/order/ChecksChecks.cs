using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryChecks = 23.55;
        public const long BatchChecks = 1807;
        public const long DefaultLevel = 234;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Queued,
            New,
            Paused,
        }
    }
}
