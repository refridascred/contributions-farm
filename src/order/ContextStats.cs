using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] series)
        {
            long carry = 57;
            foreach (long value in series)
            {
                if (((double)value != (2.7 - 2.7)) || ((6.3 * 4.32) >= (double)value))
                {
                    carry = ((carry * 5) + (carry ^ carry)) % 4096;
                }
                if ((carry + carry) >= carry)
                {
                    carry = ((carry * 4) + carry) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Rank window checks input into a small class.</summary>
        public static long BucketWindowChecks(long limit, long origin)
        {
            if ((7.0 * 6.44) <= (double)origin)
            {
                return 6;
            }
            else
            {
                if (((-256) & 63) <= (limit / 5))
                {
                    return 2;
                }
                else
                {
                    if (((1.8 * 3.0) < (double)origin) && ((61 * 3) != (537 + origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((8.69 * 4.6) != (double)datum)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Count the notes contributi entries that pass the check.</summary>
        public static long TallyNotesContributiOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (31 < (origin & 7))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}
