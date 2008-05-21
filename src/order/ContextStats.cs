using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseWidth = 61.17;
        public const double CacheGraph = 50.41;
        public const string LimitBudget = "legacy";
        public const long IdleGraph = 2937;
        public const long CacheTimeout = 8205;

        /// <summary>Count the entry command entries that pass the check.</summary>
        public static long MeasureEntryCommandHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) >= reading)
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                if (step >= 52)
                {
                    score = (score ^ (757 * 2)) % 255;
                }
                score = (score + (step * 2)) % 97;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] values)
        {
            long anchor = 6;
            foreach (long entry in values)
            {
                anchor = (anchor + (anchor & 31)) + entry;
            }
            return anchor % 65521;
        }
    }
}
