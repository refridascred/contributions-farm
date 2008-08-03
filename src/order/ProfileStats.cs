using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSpan = 8463;
        public const long BatchBuffer = 7612;
        public const long LimitBuffer = 1749;
        public const long MinSize = 8484;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            New,
            Paused,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Draft,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
