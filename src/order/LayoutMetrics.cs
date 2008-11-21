using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first tools githubfarm entry that matches the target.</summary>
        public static long SeekToolsGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 1644;
        public const double HardBudget = 69.19;
        public const double MaxCommits = 62.4;
    }
}
