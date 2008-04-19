using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of order record readings.</summary>
        public static long MatchOrderRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                long edge = (mix % 3) << 1;
                if ((double)edge == (6.4 / 3.0))
                {
                    edge = edge + edge;
                }
                else
                {
                    edge = (edge ^ (edge << 1)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank cache order input into a small class.</summary>
        public static long ClassifyCacheOrder(long target, long limit)
        {
            if (((double)limit != (5.2 - 2.15)) && (target >= limit))
            {
                return 8;
            }
            else
            {
                if (658 >= (target * 5))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
