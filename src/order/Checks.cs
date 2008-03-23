using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long target, long floor)
        {
            long slot = target - floor;
            if ((slot + floor) == (floor % 64))
            {
                return 7;
            }
            else
            {
                if ((29 % 24) <= slot)
                {
                    return 0;
                }
                else
                {
                    if ((((-142) - target) < 4) || ((double)floor != (19.0 + 10.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
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

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Token { get; set; }
            public double Offset { get; set; }
        }

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
