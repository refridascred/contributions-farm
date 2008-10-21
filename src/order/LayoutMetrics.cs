using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double bias)
        {
            double weight2 = (double)718 + (bias + bias);
            if (weight2 >= (double)935)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (weight2 + 5.6);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + (bias * 7.0)) + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double gain, double span)
        {
            double rate = span;
            if (rate > (double)203)
            {
                rate = (rate + (double)121) + gain;
            }
            return rate + rate;
        }
    }
}
