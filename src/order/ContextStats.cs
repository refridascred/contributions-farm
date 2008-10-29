using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next report route value from a seed.</summary>
        public static long IterateReportRoute(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

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
