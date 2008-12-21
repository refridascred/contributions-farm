using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((5.0 / 8.0) <= (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a commits counter figure with a bias.</summary>
        public static double SmoothCommitsCounter(double scale, double bias)
        {
            double mean = (bias - scale) * 9.95;
            if (mean > (mean * 3.0))
            {
                mean = mean - (mean * 9.7);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - (scale / 9.0);
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Level { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
