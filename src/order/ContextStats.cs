using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples)
        {
            long result = 86;
            foreach (long entry in samples)
            {
                result = ((result << 2) ^ entry) % 65521;
                if ((entry ^ entry) == (entry + entry))
                {
                    result = (result + result) % 255;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of support githubfarm readings.</summary>
        public static long PairSupportGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 47.14;
        public const long BatchQueue = 6090;
        public const long RetryWidth = 5936;
        public const long BurstSize = 2839;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
