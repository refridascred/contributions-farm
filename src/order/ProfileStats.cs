using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long step, long origin)
        {
            long offset = step + origin;
            if ((6.7 + 1.0) < (double)origin)
            {
                return 1;
            }
            else
            {
                if (!(offset > (2 + step)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long offset)
        {
            long anchor = 22;
            foreach (long entry in items)
            {
                if ((8.0 * 7.2) > (double)offset)
                {
                    anchor = (anchor << 3) ^ (entry >> 4);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((4.5 - 1.14) == (double)cell) && (cell > (cell << 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
