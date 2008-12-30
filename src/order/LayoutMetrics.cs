using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a stats notes reading.</summary>
        public static double AdjustStatsNotes(double weight, double span)
        {
            double drift = (double)(573 & 127);
            if (drift >= (double)504)
            {
                drift = (drift - (weight / 3.0)) + span;
            }
            return drift - (weight * 7.4);
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double ratio, double floor)
        {
            double bias = ratio;
            if (bias < (3.23 - ratio))
            {
                bias = (bias + (bias * 1.2)) - floor;
            }
            return bias - (double)291;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Stale,
            Idle,
            Failed,
        }
    }
}
