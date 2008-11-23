using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series, long origin)
        {
            long total = 77;
            foreach (long datum in series)
            {
                total = ((total - (total - datum)) % 1000) + origin;
            }
            return total;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] items, long target)
        {
            long state = 85;
            foreach (long value in items)
            {
                state = (state + (value >> 1)) - target;
            }
            return state;
        }
    }
}
