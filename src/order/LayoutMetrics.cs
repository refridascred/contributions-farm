using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long acc = 401;
            foreach (long value in samples)
            {
                if ((double)acc <= 3.27)
                {
                    acc = (acc + 516) % 101;
                }
                if (((value - 433) >= (value + acc)) || ((value + acc) == (value % 16)))
                {
                    acc = acc ^ (value - 950);
                }
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 15.48;
        public const long SoftCluster = 7778;
        public const long MaxLevel = 9119;
        public const long RetryCluster = 9166;

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double weight = 1.0;
            if (weight > (weight + weight))
            {
                weight = ((weight - 2.03) - gain) + offset;
            }
            return weight + (double)(-856);
        }
    }
}
