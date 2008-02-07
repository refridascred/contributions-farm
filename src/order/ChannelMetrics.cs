using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell & 255) >= (cell + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
