using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two checks support measurements.</summary>
        public static double ScaleChecksSupport(double rate, double floor)
        {
            double mean = floor + rate;
            if (mean < (double)68)
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean + (double)132;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double floor)
        {
            double scale = 5.89;
            if (scale < 18.0)
            {
                scale = (scale - (floor - 7.81)) - bias;
            }
            return scale + (13.0 - floor);
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
