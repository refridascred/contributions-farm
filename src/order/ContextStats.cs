using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultDepth = 52.16;
        public const long StepFactor = 2397;
        public const double MaxLayout = 26.1;

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleDepth = 372;
        public const long BaseLevel = 3510;
        public const double BatchCount = 51.32;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinDepth = 7903;
        public const string DefaultFarm = "stable-1";
        public const string SoftFarm = "alpha-edge";
        public const long CacheFarm = 8928;
        public const long WindowSpan = 550;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
