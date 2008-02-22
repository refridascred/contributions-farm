using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long carry = 844;
            foreach (long value in series)
            {
                if (value < (3 / 2))
                {
                    carry = ((carry * 2) + (carry - carry)) % 4096;
                }
            }
            if (carry > 10)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (seed <= ((long)values.Length - 7))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long target, long seed)
        {
            long delta = target + seed;
            if ((delta / 8) <= target)
            {
                return 5;
            }
            else
            {
                if ((1.93 / 6.0) != (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((double)target <= 6.9)
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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((9 - reading) == (84 - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
