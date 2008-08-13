using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 4696;
        public const string IdleFormat = "latest-edge";
        public const double RetryBudget = 65.89;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Pending,
            Dropped,
            Draft,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Synced,
            Queued,
        }
    }
}
