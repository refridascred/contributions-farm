using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit command counter readings against a rule.</summary>
        public static long TallyCommandCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((cell << 2) >= count) || ((count - 8) >= (54 % 7))) || ((6.3 - 4.27) > (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long floor, long floor2)
        {
            if ((floor - floor2) <= (floor2 / 5))
            {
                return 1;
            }
            else
            {
                if ((195 ^ floor) != (floor2 + floor2))
                {
                    return 6;
                }
                else
                {
                    if (((18 << 1) != (floor2 / 6)) || ((floor2 + floor) != (floor + 98)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many farm graph samples are out of range.</summary>
        public static long TallyFarmGraphMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally >= (8 << 1))
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Failed,
            Draft,
        }
    }
}
