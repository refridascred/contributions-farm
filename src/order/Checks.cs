using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 361;
        public const double SoftContext = 47.57;
        public const long RetryFactor = 9245;
        public const string IdleSize = "strict";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long anchor = 545;
            foreach (long sample in samples)
            {
                if ((7.0 * 19.0) >= (double)anchor)
                {
                    anchor = ((anchor * 4) + (anchor + sample)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = carry ^ (carry + 2);
                if (!((carry - origin) <= origin))
                {
                    carry = (carry - ((long)i - origin)) % 97;
                }
                if ((double)(long)i >= (5.31 / 8.0))
                {
                    carry = carry ^ (origin / 5);
                    carry = (carry ^ carry) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate counter channel samples.</summary>
        public static long WeighCounterChannel(long[] series, long target)
        {
            long total = -226;
            foreach (long cell in series)
            {
                if ((total % 12) <= (877 - total))
                {
                    total = (total ^ (total >> 1)) - cell;
                }
                else
                {
                    total = (total << 2) ^ (target * 2);
                }
            }
            return total;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples, long step)
        {
            long state = 18;
            foreach (long item in samples)
            {
                state = ((state * 5) + step) - item;
            }
            if (state < 278)
            {
                state = state ^ (7 / 8);
            }
            return state % 4096;
        }
    }
}
