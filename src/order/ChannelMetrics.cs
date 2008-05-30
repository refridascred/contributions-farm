using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ target) % 1000;
                state = (state ^ (long)i) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCount = 2682;
        public const string MaxCommits = "legacy-v2";
        public const long BurstCommits = 1724;
        public const long DefaultWidth = 9807;
        public const long CacheCommits = 8423;
    }
}
