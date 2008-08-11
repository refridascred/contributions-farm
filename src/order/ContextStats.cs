using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] values, long seed)
        {
            long sum = 412;
            foreach (long sample in values)
            {
                if ((sample + sum) > seed)
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
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
