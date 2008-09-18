using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Scale a buffer metric figure with a bias.</summary>
        public static double ProjectBufferMetric(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 >= (rate / 7.0))
            {
                rate2 = (rate2 + (rate / 5.0)) - offset;
            }
            return rate2 + rate;
        }
    }
}
