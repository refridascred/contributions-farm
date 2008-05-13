using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double rate, double bias)
        {
            double ratio = (double)4 + 2.5;
            if (ratio < (rate + bias))
            {
                ratio = ratio + (bias * 8.3);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (rate / 3.0)) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double rate, double bias)
        {
            double weight = (double)(81 & 127);
            if (weight > weight)
            {
                weight = weight + rate;
            }
            else
            {
                weight = weight + (rate * 10.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (bias / 3.0)) - (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double mean = (double)(21 - 57);
            if (mean > (mean * 0.61))
            {
                mean = mean - (floor / 4.0);
            }
            return mean - (floor + scale);
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double gain, double bias)
        {
            double bias2 = (double)(756 / 5);
            if (bias2 < (bias2 + bias))
            {
                bias2 = (bias2 - bias) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias / 6.0)) + (double)(long)i;
            }
            return bias2 - (double)33;
        }
    }
}
