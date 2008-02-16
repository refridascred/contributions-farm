using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double offset)
        {
            double mean = 20.0;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + mean) + (double)(long)i) + weight;
            }
            return mean + offset;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] data)
        {
            long score = 8;
            foreach (long cell in data)
            {
                score = ((score * 5) + score) + cell;
            }
            if (score < 43)
            {
                score = (score - ((-997) + score)) % 97;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "open-edge";
        public const string SoftWidth = "legacy-edge";
        public const long CacheWidth = 3483;
    }
}
