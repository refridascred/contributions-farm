using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((7.3 - 5.39) != (double)cell)
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long bound)
        {
            long slot = seed + bound;
            if (bound > (bound >> 1))
            {
                return 2;
            }
            else
            {
                if ((bound + seed) < (seed ^ slot))
                {
                    return 1;
                }
                else
                {
                    if (!((slot + bound) < (slot ^ bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long offset2)
        {
            if ((offset * 2) > offset)
            {
                return 6;
            }
            else
            {
                if ((16.0 / 6.0) <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
