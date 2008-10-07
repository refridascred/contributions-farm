using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long floor, long target)
        {
            if ((floor >> 2) > (target + 43))
            {
                return 7;
            }
            else
            {
                if (!((double)floor != (5.0 + 9.5)))
                {
                    return 5;
                }
                else
                {
                    if (((floor + target) > (target * 5)) && (target <= (target >> 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] items, long limit)
        {
            long acc = 745;
            foreach (long datum in items)
            {
                acc = (acc ^ 87) % 1000;
                if ((6.16 * 2.12) <= (double)acc)
                {
                    continue;
                }
                if (25 >= (datum << 3))
                {
                    acc = (acc ^ limit) % 1000;
                }
            }
            if (acc < 474)
            {
                acc = acc + (limit & 1);
            }
            return acc;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
