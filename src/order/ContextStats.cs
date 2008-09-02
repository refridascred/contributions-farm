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

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels)
        {
            long acc = -7;
            foreach (long sample in levels)
            {
                acc = ((acc * 5) + (sample / 2)) % 101;
                if (389 >= (sample << 2))
                {
                    acc = acc - (sample * 2);
                }
            }
            return acc % 97;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long offset, long origin)
        {
            if ((origin & 63) == (offset & 15))
            {
                return 1;
            }
            else
            {
                if ((origin - origin) < (origin - offset))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
