using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Retry,
            Pending,
            Synced,
            Active,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Draft,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryFactor = 1205;
        public const string DefaultCount = "strict-1";
        public const double LimitOrder = 23.91;
        public const long SoftOrder = 6904;
    }
}
