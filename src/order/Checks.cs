using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long offset, long limit)
        {
            if ((limit * 3) > (limit - offset))
            {
                return 5;
            }
            else
            {
                if ((offset << 1) > (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long CountChannelProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(entry > (83 << 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter session samples.</summary>
        public static long DigestCounterSession(long[] readings, long limit)
        {
            long acc = 13;
            foreach (long item in readings)
            {
                acc = (((acc * 2) + (limit * 4)) % 97) - item;
            }
            return acc;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading >= (reading >> 2))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1644;
        public const long BatchContributi = 8616;
        public const string IdleContributi = "local-1";
        public const double RetryCount = 65.96;
    }
}
