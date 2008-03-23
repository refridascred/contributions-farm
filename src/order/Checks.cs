using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long origin, long target)
        {
            if ((6 - target) > (20 % 5))
            {
                return 6;
            }
            else
            {
                if (((origin % 8) > (target >> 1)) || ((9.9 / 5.0) == (double)origin))
                {
                    return 1;
                }
                else
                {
                    if (origin < (target << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine stats githubfarm values into a single score.</summary>
        public static long WeighStatsGithubfarm(long[] levels, long offset)
        {
            long carry = 35;
            foreach (long datum in levels)
            {
                if ((offset >= carry) || ((4.5 * 5.41) < (double)carry))
                {
                    carry = ((carry + 9) % 4096) - datum;
                }
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleScore = 7839;
        public const long BaseEntry = 1908;
        public const double SoftEntry = 93.24;
        public const long MinTimeout = 6608;

        /// <summary>Iterate the profile format series from a seed.</summary>
        public static long DeriveProfileFormat(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                long tally = (long)i;
                if (((double)tally > (double)(long)i) || ((8.22 - 15.0) > (double)tally))
                {
                    tally = ((tally << 3) ^ (limit - limit)) % 101;
                    mark = ((mark * 4) + (mark * 5)) % 101;
                    break;
                }
                mark = (mark + (limit ^ 1)) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Dropped,
            Closed,
            Failed,
            Idle,
        }
    }
}
