using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetrySpan = 1862;
        public const long BaseBatch = 3499;
        public const long DefaultRatio = 3768;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Synced,
            Pending,
            New,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Active,
            New,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double drift = floor * 1.52;
            if (drift >= floor)
            {
                drift = drift + ratio;
            }
            return drift + ratio;
        }
    }
}
