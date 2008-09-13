using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((((sample * 3) >= (seen - sample)) || (seen <= (long)series.Length)) && (((double)sample != (10.0 * 5.5)) || (seen < (sample * 4))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Failed,
            Closed,
            New,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double ratio, double offset)
        {
            double mean = 0.59;
            if (mean < (ratio / 5.0))
            {
                mean = mean - 15.0;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
