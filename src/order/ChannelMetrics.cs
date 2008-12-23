using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double scale, double offset)
        {
            double drift = scale;
            if (drift < 4.7)
            {
                drift = drift + (drift / 2.0);
            }
            else
            {
                drift = drift + (scale * 0.6);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift + (4.6 - offset);
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((7.12 - 6.0) > (double)cell)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
