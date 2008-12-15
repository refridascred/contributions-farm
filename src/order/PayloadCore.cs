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

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double rate, double floor)
        {
            double gain = floor;
            if (gain >= (double)204)
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (floor - rate)) + (double)(long)i;
            }
            return gain - 7.0;
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
