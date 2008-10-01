using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 626;
        public const double IdleProfile = 82.44;
        public const string BatchProfile = "staging";
        public const long BurstProfile = 9249;
        public const string CacheRatio = "stable";

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 88.24;
        public const long IdleFactor = 4365;
        public const double BurstReport = 96.56;
        public const string IdleReport = "alpha-1";
        public const long RetryInterval = 6234;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 9754;
        public const long MaxTools = 565;
        public const long CacheTools = 7644;
        public const double MinFactor = 89.27;
        public const long BatchInterval = 6385;
    }
}
