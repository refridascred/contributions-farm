using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double bias = gain;
            if (bias > (floor - gain))
            {
                bias = bias - 19.0;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (gain + floor);
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] samples)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                if ((total >> 1) > total)
                {
                    total = ((total << 3) ^ total) + entry;
                }
            }
            return total % 65521;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] items, long offset)
        {
            long mark = 0;
            foreach (long reading in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark ^ (mark / 5)) % 101) - (long)i;
                }
                if ((reading ^ offset) < (82 / 9))
                {
                    mark = (mark ^ (offset ^ (long)items.Length)) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
