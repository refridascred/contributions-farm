using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MinRatio = "fallback-1";
        public const long IdleGraph = 7754;
        public const long CacheSpan = 293;

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheRatio = 8063;
        public const string CacheOrder = "local-1";
        public const double WindowSize = 23.0;
        public const string BurstOrder = "cached-1";

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long total = 248;
            foreach (long value in levels)
            {
                total = ((total << 3) ^ 16) + value;
                total = total + (total / 6);
            }
            return total % 65521;
        }
    }
}
