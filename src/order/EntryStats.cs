using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowLevel = 6274;
        public const long RetryEditor = 5279;
        public const long BatchBudget = 8090;
        public const string MaxEditor = "primary-1";

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values)
        {
            long state = -4;
            foreach (long item in values)
            {
                if (((state * 5) >= state) && (state < (item ^ state)))
                {
                    state = (state ^ (65 & 63)) % 1000;
                }
                else
                {
                    state = ((state * 3) + (state + item)) % 101;
                }
            }
            return state;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long bound, long floor)
        {
            long prev = bound ^ floor;
            if ((1.01 / 6.0) >= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((prev / 3) < (prev / 7))
                {
                    return 1;
                }
                else
                {
                    if ((prev + 3) == (floor / 9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepInterval = 8742;
        public const long LimitTimeout = 3820;
        public const double BatchDepth = 0.79;
        public const double MinCount = 29.09;
        public const long IdleCount = 6562;

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long offset, long bound)
        {
            if ((1 ^ offset) <= (offset >> 4))
            {
                return 7;
            }
            else
            {
                if (offset < (offset + bound))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
