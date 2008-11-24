using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 9644;
        public const string HardGithubfarm = "cached-edge";
        public const double SoftWidth = 42.0;
        public const string BatchGithubfarm = "cached-v2";

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultRatio = 5881;
        public const double WindowCluster = 23.32;
        public const long BurstCluster = 8924;
        public const long StepCluster = 9510;
    }
}
