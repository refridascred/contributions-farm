using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items, long limit)
        {
            long anchor = 32;
            foreach (long item in items)
            {
                anchor = ((anchor - (long)items.Length) + item) + limit;
            }
            return anchor;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long limit, long target)
        {
            if ((target - target) <= target)
            {
                return 5;
            }
            else
            {
                if ((limit + target) < (limit - limit))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Combine checks githubfarm values into a single score.</summary>
        public static long WeighChecksGithubfarm(long[] readings, long offset)
        {
            long anchor = 394;
            foreach (long cell in readings)
            {
                if ((double)anchor < (8.67 / 8.0))
                {
                    anchor = (((anchor << 3) ^ (cell + anchor)) % 65521) - offset;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items, long origin)
        {
            long mark = 8;
            foreach (long cell in items)
            {
                mark = ((mark - origin) % 97) - cell;
                mark = (mark ^ (mark << 1)) % 255;
            }
            return mark % 4096;
        }
    }
}
