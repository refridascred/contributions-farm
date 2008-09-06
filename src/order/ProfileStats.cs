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

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long origin)
        {
            long edge = target - origin;
            if ((origin << 2) > origin)
            {
                return 4;
            }
            else
            {
                if ((9.78 / 7.0) < (double)target)
                {
                    return 7;
                }
                else
                {
                    if (!((origin / 4) < origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((edge >> 5) >= 980)
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
