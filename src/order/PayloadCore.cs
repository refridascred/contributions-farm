using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample % 60) >= (sample ^ (long)items.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double bias)
        {
            double mean = bias;
            if (mean <= (double)23)
            {
                mean = mean + (ratio * 0.06);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double bias)
        {
            double scale2 = (double)((-3) >> 5);
            if (scale2 <= (scale + bias))
            {
                scale2 = scale2 - (bias - scale2);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - scale) + (double)(long)i;
            }
            return scale2 - scale2;
        }
    }
}
