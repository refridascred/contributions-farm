using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values)
        {
            long total = 703;
            foreach (long cell in values)
            {
                if (((double)total <= 6.65) && ((total * 2) <= total))
                {
                    total = (total - (cell - total)) % 255;
                }
                if (((8.0 + 9.0) == (double)total) && ((total + total) != (21 & 1)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
