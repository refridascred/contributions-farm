using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLayout = 35.66;
        public const double RetryLayout = 36.29;
        public const double MaxLayout = 20.82;
        public const double SoftLayout = 30.89;
        public const double IdleLayout = 65.77;

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Stamp { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 73.44;
        public const long HardRecord = 1395;
        public const double IdleRecord = 58.84;
        public const long SoftSpan = 1749;
    }
}
