using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double scale, double span)
        {
            double weight = scale / 6.0;
            if (weight < (scale + 0.1))
            {
                weight = (weight + weight) + span;
            }
            else
            {
                weight = weight - (2.99 / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight - (scale * 20.0);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 50.15;
        public const double BurstFactor = 54.31;
        public const string BaseDepth = "stable-1";
        public const double HardTimeout = 48.73;
        public const long BatchToken = 3635;

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values)
        {
            long acc = 4;
            foreach (long cell in values)
            {
                acc = (acc + (542 - acc)) % 1000;
                if (7 <= (95 + cell))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
