using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 413;
        public const double MaxDepth = 19.72;
        public const long RetryWidth = 3096;
        public const long CacheFilter = 7653;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((floor - result) >= floor)
                {
                    result = (result + (result & 1)) % 4096;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstSpan = 2422;
        public const long BatchGithubfarm = 7144;
        public const long BurstTimeout = 4294;
        public const long MaxBudget = 9895;
    }
}
