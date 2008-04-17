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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) >= 61)
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
