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

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (seed >= (matches % 5))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
