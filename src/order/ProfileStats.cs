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

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "open-edge";
        public const string SoftWidth = "legacy-edge";
        public const long CacheWidth = 3483;
    }
}
