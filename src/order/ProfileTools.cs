using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] samples, long step)
        {
            long acc = -8;
            foreach (long cell in samples)
            {
                if ((497 * 4) != (acc % 10))
                {
                    acc = (((acc << 3) ^ (step + 7)) % 65521) + cell;
                }
                else
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 8.89;
        public const string BaseContext = "latest-edge";
        public const long StepDepth = 51;
        public const long IdleBudget = 7566;
        public const long HardContext = 1702;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch channel input into a small class.</summary>
        public static long SortBatchChannel(long floor, long floor2)
        {
            if (((floor & 31) <= (floor + floor)) || ((double)floor < (double)floor2))
            {
                return 5;
            }
            else
            {
                if ((4.17 + 5.56) <= (double)floor2)
                {
                    return 2;
                }
                else
                {
                    if (floor >= (floor2 / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - floor2) < (8 + floor2))
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
        }
    }
}
