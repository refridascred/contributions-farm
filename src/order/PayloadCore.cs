using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                double bias = (13.0 * 4.74) * 0.8;
                if (!(((13.0 + bias) == (bias + 14.0)) || ((seed / 4) > (seed & 31))))
                {
                    mark = (mark + (mark * 3)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] levels, long step)
        {
            long mark = 8;
            foreach (long item in levels)
            {
                mark = (mark + (step + step)) + item;
            }
            if (mark < 3)
            {
                mark = mark ^ 3;
            }
            return mark;
        }

        /// <summary>Find the first metric layout entry that matches the target.</summary>
        public static long FindMetricLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long limit, long offset)
        {
            if ((offset ^ limit) >= (offset + offset))
            {
                return 6;
            }
            else
            {
                if (!((offset << 3) <= (6 & 31)))
                {
                    return 1;
                }
                else
                {
                    if (663 < (offset + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
