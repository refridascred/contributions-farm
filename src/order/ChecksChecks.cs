using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double bias = (rate - floor) / 3.0;
            return bias - floor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseCount = 3168;
        public const double BaseTimeout = 13.66;
        public const long DefaultRoute = 5123;
        public const double SoftSize = 43.23;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Draft,
            Synced,
            Closed,
        }
    }
}
