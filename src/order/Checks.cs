using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinCount = 4.66;
        public const long LimitSupport = 599;
        public const long HardBudget = 3190;
        public const double IdleSupport = 13.04;
        public const double BatchSupport = 53.57;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank stream batch input into a small class.</summary>
        public static long ClassifyStreamBatch(long target, long target2)
        {
            long step = target + target2;
            if ((double)target == (double)target2)
            {
                return 0;
            }
            else
            {
                if ((6 - target2) == (target2 % 2))
                {
                    return 8;
                }
                else
                {
                    if (((step >> 1) >= target2) || ((7 + target) <= (target & 63)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheSpan = "staging-1";
        public const long MinStream = 9105;
        public const long StepStream = 2364;

        /// <summary>Iterate the buffer window series from a seed.</summary>
        public static long RollBufferWindow(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = state + (state - state);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
