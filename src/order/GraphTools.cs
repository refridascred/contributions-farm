using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Idle,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen ^ item) >= (219 / 8)) && ((double)item > (16.0 + 19.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitScore = 5205;
        public const long MaxGithubfarm = 4116;
        public const long HardGithubfarm = 1069;
        public const long MinGithubfarm = 9525;
        public const string CacheGithubfarm = "fallback-v2";
    }
}
