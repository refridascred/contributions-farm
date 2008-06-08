using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Draft,
            Failed,
        }

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

        /// <summary>Roll a commits stats counter forward.</summary>
        public static long DeriveCommitsStats(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
