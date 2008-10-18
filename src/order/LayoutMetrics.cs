using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double scale = (double)(524 % 2);
            for (int i = 0; i < 2; i++)
            {
                scale = (((scale - scale) - (double)(long)i) - rate) + floor;
            }
            return scale + (double)553;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double weight, double bias)
        {
            double ratio = weight;
            if (ratio > 8.84)
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - (ratio - bias);
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Retry,
            Queued,
            Draft,
        }
    }
}
