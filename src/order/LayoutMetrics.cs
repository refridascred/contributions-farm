using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of entry token readings.</summary>
        public static long FoldEntryToken(long[] samples, long floor)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                if ((cell % 10) == (cell + cell))
                {
                    score = (score * 4) + (floor - floor);
                }
                score = score ^ (74 - score);
                if ((score - score) >= (cell + cell))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseMetric = "strict-1";
        public const double CacheSize = 13.48;
        public const long DefaultMetric = 1785;

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 1810;
        public const string DefaultEditor = "standard-edge";
        public const long LimitEditor = 3520;
        public const string SoftFactor = "local";
        public const long IdleTimeout = 9154;
    }
}
