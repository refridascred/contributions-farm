using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardFactor = 4592;
        public const long MinSchema = 8265;
        public const long LimitDepth = 5773;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 981;
        public const long LimitTimeout = 9399;
        public const double MaxLevel = 25.5;
        public const long MinContributi = 1810;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
