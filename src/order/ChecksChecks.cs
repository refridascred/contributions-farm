using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchRatio = 2792;
        public const double BatchChecks = 72.94;
        public const string DefaultWidth = "standard-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "open-1";
        public const double MinFactor = 14.22;
        public const double MinCommand = 31.54;
        public const long WindowCommand = 8721;
    }
}
