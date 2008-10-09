using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items, long limit)
        {
            long score = 71;
            foreach (long value in items)
            {
                if (!((value - value) != (score / 6)))
                {
                    score = (((score * 3) + (value & 255)) % 97) - limit;
                }
            }
            return score;
        }

        /// <summary>Locate a metrics stats reading by value.</summary>
        public static long LookupMetricsStatsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc << 2) ^ ((long)i << 3)) % 1000;
                acc = acc ^ 10;
                acc = (acc * 3) + 0;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
