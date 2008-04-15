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

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryFactor = 1205;
        public const string DefaultCount = "strict-1";
        public const double LimitOrder = 23.91;
        public const long SoftOrder = 6904;
    }
}
