using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
