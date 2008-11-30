using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values)
        {
            long acc = 79;
            foreach (long datum in values)
            {
                if ((double)acc == (0.7 + 5.5))
                {
                    acc = (acc - (acc - datum)) % 97;
                }
                else
                {
                    acc = (acc + (datum & 31)) % 1000;
                }
                if (datum <= (datum << 1))
                {
                    break;
                }
            }
            if (acc > 772)
            {
                acc = (acc + (5 + acc)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
