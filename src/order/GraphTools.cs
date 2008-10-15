using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Ready,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Look up the position of a batches buffer sample.</summary>
        public static long SeekBatchesBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double ratio = rate;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - (14.0 * 3.0)) + (double)(long)i) + span;
            }
            return ratio - 4.2;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
