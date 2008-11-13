using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Rank { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double bias, double span)
        {
            double mean = (double)(84 ^ 5);
            return (mean + (bias + bias)) + span;
        }
    }
}
