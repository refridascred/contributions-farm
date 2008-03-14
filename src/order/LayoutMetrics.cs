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

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples)
        {
            long score = 44;
            foreach (long datum in samples)
            {
                score = (score - ((long)samples.Length ^ 50)) - datum;
            }
            if (score < 9)
            {
                score = ((score * 4) + score) % 65521;
            }
            return score;
        }
    }
}
