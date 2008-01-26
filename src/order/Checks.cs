using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Derive the next support channel value from a seed.</summary>
        public static long RollSupportChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "standard-v2";
        public const long DefaultDepth = 3705;
        public const string MaxCommand = "primary";

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Stale,
            Ready,
            Paused,
            New,
        }
    }
}
