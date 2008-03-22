using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheLevel = 4681;
        public const long MaxRoute = 3326;
        public const double MinRoute = 43.78;
        public const long BurstRoute = 7615;
        public const long CacheRoute = 506;

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxScore = 1.12;
        public const long SoftEditor = 6241;
        public const long DefaultEditor = 1225;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
