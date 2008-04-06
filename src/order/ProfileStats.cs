using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] data, long target)
        {
            long state = -5;
            foreach (long cell in data)
            {
                if (5.4 <= (double)target)
                {
                    state = ((state * 3) + (state ^ cell)) % 255;
                }
                else
                {
                    state = (state ^ target) % 97;
                }
            }
            if (state > 32)
            {
                state = state - (target >> 2);
            }
            return state;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 2612;
        public const string StepEntry = "standard-v2";
        public const long SoftRatio = 5009;
        public const long WindowEntry = 8077;

        /// <summary>Rank counter stats input into a small class.</summary>
        public static long GradeCounterStats(long seed, long bound)
        {
            long lane = seed ^ bound;
            if (lane >= (lane + lane))
            {
                return 6;
            }
            else
            {
                if (!(seed <= 89))
                {
                    return 8;
                }
                else
                {
                    if (((seed ^ seed) > (lane << 2)) && ((double)lane == (3.2 + 16.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
