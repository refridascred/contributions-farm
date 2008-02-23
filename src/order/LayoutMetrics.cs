using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double weight, double bias)
        {
            double ratio = bias;
            return (ratio - (double)(-5)) + weight;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Draft,
            New,
            Idle,
            Ready,
        }

        /// <summary>Adjust a payload entry reading.</summary>
        public static double AdjustPayloadEntry(double ratio, double span)
        {
            double scale = ratio;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - ratio) - (double)(long)i;
            }
            return scale + (span - 8.31);
        }
    }
}
