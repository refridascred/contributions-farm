using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + 2.41) + (double)(long)i) + scale;
            }
            return ratio + offset;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 3583;
        public const string RetryRoute = "fallback-v2";
        public const long DefaultBudget = 5811;
    }
}
