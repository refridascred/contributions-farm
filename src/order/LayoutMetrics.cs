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

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double offset)
        {
            double scale = offset + (2.7 / 8.0);
            return scale + gain;
        }
    }
}
