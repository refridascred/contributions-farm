using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 626;
        public const double IdleProfile = 82.44;
        public const string BatchProfile = "staging";
        public const long BurstProfile = 9249;
        public const string CacheRatio = "stable";

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheSize = 9573;
        public const long IdleBudget = 3114;
        public const long CacheDepth = 222;
        public const long LimitInterval = 9975;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
