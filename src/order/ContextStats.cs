using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 4061;
        public const long IdleSize = 810;
        public const long WindowChannel = 8286;
        public const long BurstChannel = 6161;
        public const long StepInterval = 3443;

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheBudget = 3044;
        public const long DefaultCount = 7902;
        public const long DefaultCache = 960;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstSize = 4339;
        public const double BurstLevel = 58.07;
        public const long HardFactor = 7944;
    }
}
