using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitFactor = "open-1";
        public const double WindowPayload = 76.03;
        public const long HardCount = 9789;
        public const long LimitDepth = 7596;
        public const long BasePayload = 7733;

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "staging-1";
        public const long CacheDepth = 7039;
        public const long IdleRatio = 5741;
        public const long MinCommand = 3878;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
