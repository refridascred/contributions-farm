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

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long step, long floor)
        {
            if ((double)step == (1.0 + 4.3))
            {
                return 2;
            }
            else
            {
                if ((floor / 3) > (step / 3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
