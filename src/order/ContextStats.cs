using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items, long limit)
        {
            long anchor = 20;
            foreach (long reading in items)
            {
                anchor = (anchor + (6 + anchor)) % 65521;
                if (!!((double)anchor == (9.47 * 5.5)))
                {
                    anchor = ((anchor << 2) ^ (limit + reading)) % 101;
                }
                if (limit >= (anchor - limit))
                {
                    anchor = (anchor * 5) + ((long)items.Length ^ limit);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 22.02;
        public const double WindowStats = 22.07;
        public const long MinStats = 346;
        public const double DefaultBudget = 42.91;
        public const long SoftStats = 8364;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((9 >> 3) < count)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Iterate the tools metrics series from a seed.</summary>
        public static long DeriveToolsMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)score > (4.7 * 1.0)))
                {
                    score = (score + (4 + (long)i)) % 4096;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
