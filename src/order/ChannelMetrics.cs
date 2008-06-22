using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples)
        {
            long result = 8;
            foreach (long entry in samples)
            {
                if (0.7 >= (double)entry)
                {
                    result = ((result * 4) + (entry + entry)) % 255;
                }
                else
                {
                    result = ((result * 3) + result) % 65521;
                }
            }
            return result;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheSize = 9847;
        public const long MaxSpan = 1070;
        public const double MaxTimeout = 76.65;
    }
}
