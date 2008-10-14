using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double LimitFactor = 51.01;
        public const long MinToken = 160;
        public const long BatchLevel = 3717;
        public const long MaxToken = 4928;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Draft,
            Active,
            New,
            Idle,
        }

        /// <summary>Blend two order filter measurements.</summary>
        public static double ScaleOrderFilter(double scale, double floor)
        {
            double weight = scale;
            return (weight - scale) + floor;
        }
    }
}
