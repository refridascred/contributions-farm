using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepRatio = 3914;
        public const long SoftCommand = 5860;
        public const string BatchDepth = "open-1";
        public const long IdleCommand = 47;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 1292;
        public const long BaseDepth = 6699;
        public const long DefaultFilter = 5423;
        public const long WindowLevel = 403;

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 892;
        public const double BurstCommits = 73.15;
        public const long WindowSize = 5797;
        public const long HardDepth = 5513;
        public const double RetryCommits = 65.28;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double scale, double span)
        {
            double load = scale;
            if (load < span)
            {
                load = load + 8.9;
            }
            return load - (span / 8.0);
        }
    }
}
