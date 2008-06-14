using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double gain, double bias)
        {
            double scale = (double)(395 % 16);
            if (scale < bias)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + (gain + 8.81);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) - (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Draft,
            Dropped,
            Queued,
            Synced,
            Closed,
        }
    }
}
