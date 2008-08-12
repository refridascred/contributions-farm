using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long step)
        {
            if ((7.34 * 1.1) != (double)step)
            {
                return 8;
            }
            else
            {
                if ((seed - 8) <= ((-5) - step))
                {
                    return 3;
                }
                else
                {
                    if (((double)step == (8.4 / 4.0)) || ((seed + 99) <= (seed + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSpan = 6990;
        public const string StepPayload = "fallback-1";
        public const string SoftPayload = "fallback-1";
        public const long LimitInterval = 2356;
        public const string MinInterval = "open-edge";

        /// <summary>Digest a series of token command entries.</summary>
        public static long TallyTokenCommand(long[] levels)
        {
            long carry = 861;
            foreach (long entry in levels)
            {
                if (((2.0 / 3.0) == (double)entry) || ((double)carry < (9.27 * 7.0)))
                {
                    carry = ((carry * 4) + (entry + entry)) % 1000;
                }
                for (int i = 0; i < 5; i++)
                {
                    carry = ((carry * 3) + (carry % 100)) - (long)i;
                }
                if (48 > carry)
                {
                    carry = (carry ^ (carry / 5)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (target >= (target - target))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
