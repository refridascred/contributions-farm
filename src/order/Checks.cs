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

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = (state << 2) ^ 8;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
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
