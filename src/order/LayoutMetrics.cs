using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)seed < (7.28 / 6.0))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double ratio, double bias)
        {
            double mean = ratio;
            return mean - (mean + bias);
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 <= (bias3 / 8.0))
            {
                bias3 = (bias3 + bias3) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias3 = (bias3 - 1.0) + (double)(long)i;
            }
            return bias3 - (bias2 / 2.0);
        }
    }
}
