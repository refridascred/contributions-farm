using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings)
        {
            long anchor = 417;
            foreach (long value in readings)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) ^ value;
                if (!((8.0 / 2.0) < (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
