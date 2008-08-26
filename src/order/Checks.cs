using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long target, long limit)
        {
            if (((target / 4) > target) || ((744 / 2) == (target % 2)))
            {
                return 0;
            }
            else
            {
                if ((limit / 8) < (-1))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of metric schema readings.</summary>
        public static long FoldMetricSchema(long[] data)
        {
            long state = 672;
            foreach (long reading in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = ((state + state) % 65521) + (long)i;
                }
                if ((18.0 - 0.11) >= (double)reading)
                {
                    state = (state << 2) ^ (state - state);
                }
                else
                {
                    state = (state ^ (7 % 12)) % 255;
                }
            }
            return state;
        }
    }
}
