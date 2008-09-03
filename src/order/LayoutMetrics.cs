using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of commits metric readings.</summary>
        public static long MatchCommitsMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardDepth = 64.59;
        public const string IdleScore = "fallback-1";
        public const double BaseStats = 82.92;
        public const string StepStats = "fallback-1";
        public const long RetryLevel = 3131;

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 7640;
        public const long WindowSupport = 5981;
        public const long BaseDepth = 777;
    }
}
