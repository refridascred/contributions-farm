using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value < (count / 7)) && !((count >> 5) < (value % 10)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Dropped,
            Paused,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }
    }
}
