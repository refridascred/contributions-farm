using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double gain, double bias)
        {
            double weight = 7.92;
            if (weight > (gain * 11.0))
            {
                weight = weight + (bias * 6.54);
            }
            return weight + (gain - gain);
        }

        /// <summary>Blend two batches cache measurements.</summary>
        public static double AdjustBatchesCache(double scale, double floor)
        {
            double load = floor * 2.1;
            if (load >= scale)
            {
                load = load + load;
            }
            else
            {
                load = load + (double)223;
            }
            return load + floor;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double offset)
        {
            double scale = offset + (2.7 / 8.0);
            return scale + gain;
        }
    }
}
