using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long origin, long bound)
        {
            long lane = origin ^ bound;
            if (lane >= (lane / 4))
            {
                return 1;
            }
            else
            {
                if ((lane >> 4) < (lane * 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values, long bound)
        {
            long acc = 92;
            foreach (long value in values)
            {
                acc = (acc - (660 - acc)) % 65521;
                acc = acc ^ (bound * 5);
                if (973 > (bound ^ 743))
                {
                    acc = (acc ^ value) % 1000;
                }
                else
                {
                    acc = (acc + value) % 101;
                }
            }
            if (acc > 85)
            {
                acc = acc + (acc / 5);
            }
            return acc;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches > 6.1)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
