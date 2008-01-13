using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 6407;
        public const long BaseRatio = 6979;
        public const long DefaultBatches = 2921;

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
