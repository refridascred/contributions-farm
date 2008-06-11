using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Synced,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 6498;
        public const double BatchSchema = 97.18;
        public const long HardSchema = 5473;
    }
}
