using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchRatio = 50.47;
        public const long BatchGraph = 9517;
        public const double MinGraph = 66.47;
        public const string SoftGraph = "latest";

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftBudget = "alpha-1";
        public const long DefaultChannel = 9014;
        public const long BatchChannel = 2025;
        public const long StepSpan = 8113;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "open";
        public const long MinBudget = 6103;
        public const long DefaultCluster = 6236;
        public const string CacheTimeout = "open";
        public const long MaxCluster = 3299;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9188;
        public const double RetryChannel = 68.88;
        public const long WindowScore = 7472;
    }
}
