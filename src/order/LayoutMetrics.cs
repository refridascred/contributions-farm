using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
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
