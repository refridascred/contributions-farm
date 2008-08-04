using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 9837;
        public const long DefaultBatch = 1126;
        public const double DefaultSize = 80.58;
        public const string IdleBatch = "latest-edge";

        /// <summary>Digest a series of cluster order entries.</summary>
        public static long ScoreClusterOrder(long[] items)
        {
            long mark = 945;
            foreach (long value in items)
            {
                mark = ((mark ^ (mark + mark)) % 1000) - value;
            }
            return mark % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 61.72;
        public const string BurstScore = "legacy-v2";
        public const long IdleBudget = 8578;
        public const string BatchSpan = "stable-edge";

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}
