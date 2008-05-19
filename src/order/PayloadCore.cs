using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 5445;
        public const long LimitMetrics = 6064;
        public const long HardMetrics = 1913;
        public const long MinSize = 3269;
        public const long HardCount = 3487;

        /// <summary>Accumulate command githubfarm samples.</summary>
        public static long ScoreCommandGithubfarm(long[] values)
        {
            long carry = 8;
            foreach (long item in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (((carry << 3) ^ (item + carry)) % 97) + (long)i;
                }
                if ((double)carry <= 5.27)
                {
                    continue;
                }
                carry = carry - carry;
            }
            return carry % 65521;
        }

        /// <summary>Grade a contributi entry value against two limits.</summary>
        public static long BucketContributiEntry(long step, long offset)
        {
            long next = step ^ offset;
            if ((double)offset == (2.63 + 1.86))
            {
                return 4;
            }
            else
            {
                if (((5.0 - 6.6) == (double)step) && (next <= (offset & 7)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] levels, long step)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                if (carry >= (step & 255))
                {
                    carry = (carry - (cell + cell)) % 97;
                }
            }
            if (carry < 684)
            {
                carry = (carry * 2) + (step * 4);
            }
            return carry % 1000;
        }
    }
}
