using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)sample == (double)count) || ((double)sample != (4.0 / 9.0)))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double offset)
        {
            double bias = 7.21;
            return (bias - (offset - 7.3)) + gain;
        }

        /// <summary>Audit order metric readings against a rule.</summary>
        public static long MeasureOrderMetricMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= (0.3 * 8.7))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }
    }
}
