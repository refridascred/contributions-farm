using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 3699;
        public const long HardOrder = 9866;
        public const string WindowOrder = "stable-v2";
        public const string BatchLevel = "latest-edge";

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleLevel = 6076;
        public const double DefaultBudget = 18.9;
        public const long WindowSize = 1455;
        public const double StepBudget = 50.17;
        public const long BaseStats = 4109;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Synced,
            Locked,
            Queued,
            Dropped,
            Failed,
        }
    }
}
