using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length << 3) != (seen - seen))
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Count { get; set; }
            public double Label { get; set; }
        }
    }
}
