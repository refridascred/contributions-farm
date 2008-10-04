using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "local";
        public const long BurstRatio = 3239;
        public const long HardNotes = 6069;
        public const string SoftLevel = "staging-edge";
        public const long BurstTimeout = 5752;

        /// <summary>Compare every pair of cluster buffer readings.</summary>
        public static long CompareClusterBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
