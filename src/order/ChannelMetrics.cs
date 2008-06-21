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

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "legacy";
        public const long RetryRoute = 2389;
        public const long LimitScore = 7141;
        public const long HardRoute = 1728;
        public const long WindowSize = 2233;
    }
}
