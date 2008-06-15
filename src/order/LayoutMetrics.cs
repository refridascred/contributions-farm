using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "alpha-v2";
        public const long RetryFormat = 8472;
        public const long SoftInterval = 940;
        public const string DefaultFormat = "stable";

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftFactor = 5195;
        public const long StepChannel = 1906;
        public const long HardScore = 3621;
        public const string MinFactor = "latest-v2";

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepRatio = 7580;
        public const double BaseEntry = 74.79;
        public const double BatchScore = 20.61;
        public const string IdleEntry = "stable";
        public const long BatchEntry = 1376;
    }
}
