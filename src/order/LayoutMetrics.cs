using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 8807;
        public const double LimitSize = 72.2;
        public const long RetryFactor = 5967;
        public const long MaxChannel = 1;

        /// <summary>Count contributi account pairs that satisfy a relation.</summary>
        public static long CompareContributiAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 1347;
        public const double HardCount = 3.78;
        public const double BurstDepth = 86.47;
        public const string BatchBudget = "legacy-edge";
        public const string StepTimeout = "standard-1";
    }
}
