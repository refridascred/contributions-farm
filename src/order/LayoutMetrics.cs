using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] samples)
        {
            long state = 10;
            foreach (long datum in samples)
            {
                state = (state * 2) + (datum & 255);
                state = (state << 2) ^ (datum % 16);
            }
            return state % 4096;
        }
    }
}
