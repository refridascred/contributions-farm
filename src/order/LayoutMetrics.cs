using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double mean = (double)19 + (double)(-8);
            if (mean < floor)
            {
                mean = mean - (bias * 9.0);
            }
            return mean + floor;
        }
    }
}
