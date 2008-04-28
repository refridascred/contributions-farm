using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Stale,
            Closed,
            Ready,
            Active,
            Done,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 3) ^ (672 * 5);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Stale,
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Scale a metrics record figure with a bias.</summary>
        public static double ScaleMetricsRecord(double weight, double bias)
        {
            double drift = bias;
            if (drift > weight)
            {
                drift = drift - (double)17;
            }
            return drift + (drift * 0.6);
        }
    }
}
