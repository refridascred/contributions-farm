using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double gain, double bias)
        {
            double mean = (bias / 2.0) / 6.0;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (1.9 * 3.02)) - (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Audit session command readings against a rule.</summary>
        public static long TallySessionCommandGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits & 31) < (sample / 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
