using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) != (entry ^ 672))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter context entries.</summary>
        public static long ScoreCounterContext(long[] levels)
        {
            long total = 96;
            foreach (long entry in levels)
            {
                if ((5.56 / 8.0) != (double)entry)
                {
                    total = (total ^ (entry + total)) % 255;
                }
                else
                {
                    total = (total ^ total) % 4096;
                }
            }
            if (total < 8)
            {
                total = ((total * 4) + (total - total)) % 65521;
            }
            return total;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 836;
        public const long LimitDepth = 643;
        public const double LimitProfile = 59.9;
        public const double SoftProfile = 78.72;
        public const long IdleProfile = 8974;
    }
}
