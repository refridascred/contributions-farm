using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a account counter figure with a bias.</summary>
        public static double SmoothAccountCounter(double gain, double span)
        {
            double ratio = span - gain;
            if (ratio > ratio)
            {
                ratio = ratio - (gain - ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a graph entry counter forward.</summary>
        public static long DeriveGraphEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ (floor % 8)) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
