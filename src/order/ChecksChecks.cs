using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 7846;
        public const long DefaultRatio = 1738;
        public const long SoftWidth = 6062;
        public const string LimitTimeout = "cached-1";
        public const double IdleSchema = 76.84;

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheScore = 3555;
        public const string BatchWidth = "standard-v2";
        public const long IdleTimeout = 6145;
        public const double HardTimeout = 33.04;
        public const double BurstSupport = 8.43;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
