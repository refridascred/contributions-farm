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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value > (seed ^ seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
