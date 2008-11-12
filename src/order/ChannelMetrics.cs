using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] values)
        {
            long acc = -17;
            foreach (long reading in values)
            {
                if (acc > (acc / 9))
                {
                    acc = (acc ^ (reading + reading)) % 255;
                    acc = acc + acc;
                }
                if ((reading - reading) <= 8)
                {
                    break;
                }
                if ((reading - reading) > (acc + acc))
                {
                    acc = ((acc * 5) + (reading / 6)) % 1000;
                }
            }
            if (acc > 4)
            {
                acc = acc - (37 + 23);
            }
            return acc % 1000;
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
