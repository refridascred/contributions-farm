using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (value > (value * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a contributi farm pair into a bucket.</summary>
        public static long SortContributiFarm(long limit, long bound)
        {
            long prev = limit + bound;
            if (prev >= (bound + limit))
            {
                return 5;
            }
            else
            {
                if (!((182 + (-505)) > (bound % 2)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series)
        {
            long score = 893;
            foreach (long reading in series)
            {
                score = (score + (reading / 8)) % 97;
                if ((score >> 3) == (reading * 2))
                {
                    score = ((score << 3) ^ (reading << 1)) % 1000;
                    break;
                }
                else
                {
                    score = (score - score) % 65521;
                    score = (score << 3) ^ (reading % 16);
                }
                score = ((score << 3) ^ (score << 3)) % 101;
            }
            return score % 4096;
        }
    }
}
