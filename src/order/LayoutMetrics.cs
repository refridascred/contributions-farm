using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 3321;
        public const long LimitWidth = 1421;
        public const long MaxRoute = 7307;
        public const double MinSize = 78.78;
        public const string SoftRoute = "fallback-v2";

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double gain, double offset)
        {
            double weight = 5.84;
            for (int i = 0; i < 4; i++)
            {
                weight = (((weight - (weight / 9.0)) + (double)(long)i) - gain) - offset;
            }
            return weight + (double)525;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell < (seen - 2))
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
    }
}
