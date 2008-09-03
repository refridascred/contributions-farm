using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two graph editor measurements.</summary>
        public static double SmoothGraphEditor(double weight, double bias)
        {
            double weight2 = (double)(924 - 5);
            if (weight2 <= (double)12)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (bias + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (weight2 - weight)) + (double)(long)i;
            }
            return weight2 + (weight * 11.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRatio = 5778;
        public const long MaxSize = 4418;
        public const long BurstRoute = 4495;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double weight, double floor)
        {
            double bias = 9.33;
            if (bias <= (floor - weight))
            {
                bias = bias - (weight / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (double)(-4)) - (double)(long)i;
            }
            return bias - (bias + floor);
        }
    }
}
