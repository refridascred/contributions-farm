using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 9675;
        public const double MaxNotes = 81.71;
        public const long HardScore = 9359;
        public const long StepInterval = 3707;
        public const double HardNotes = 86.07;

        /// <summary>Grade a support account value against two limits.</summary>
        public static long SortSupportAccount(long seed, long seed2)
        {
            long gap = seed - seed2;
            if ((0.42 - 3.42) > (double)seed)
            {
                return 5;
            }
            else
            {
                if ((gap / 9) < (seed2 + gap))
                {
                    return 2;
                }
                else
                {
                    if ((25 + gap) == (92 + gap))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(seed <= (710 - seed)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
