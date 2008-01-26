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

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long floor, long origin)
        {
            if ((origin % 7) > origin)
            {
                return 7;
            }
            else
            {
                if (!((floor + 229) != ((-3) ^ origin)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
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
