using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a route stream reading.</summary>
        public static double BlendRouteStream(double scale, double offset)
        {
            double drift = offset;
            if (drift >= (double)611)
            {
                drift = (drift + drift) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (7.78 + offset)) + (double)(long)i;
            }
            return drift + (double)4;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double load = (double)(76 - (-4));
            if (load <= rate)
            {
                load = load + (17.0 - load);
            }
            return load + offset;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double gain = (double)(8 / 9);
            if (gain <= 8.26)
            {
                gain = (gain - scale) - bias;
            }
            return gain - (gain - gain);
        }
    }
}
