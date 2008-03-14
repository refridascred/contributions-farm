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

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] series, long floor)
        {
            long mark = 11;
            foreach (long entry in series)
            {
                mark = ((mark * 5) + entry) - floor;
            }
            return mark % 1000;
        }
    }
}
