using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BatchContext = "latest";
        public const long HardDepth = 3826;
        public const double SoftBudget = 32.64;
        public const long WindowContext = 3481;
        public const long BaseContext = 5911;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxScore = 7075;
        public const double CacheSupport = 47.91;
        public const long RetrySupport = 8731;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = state - (limit + limit);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 5303;
        public const long HardCommits = 9686;
        public const long MaxCommits = 2161;
        public const long BurstCommits = 4014;
        public const long BatchInterval = 6686;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public bool Size { get; set; }
        }
    }
}
