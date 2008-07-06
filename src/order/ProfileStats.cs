using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the profile githubfarm entries that pass the check.</summary>
        public static long AuditProfileGithubfarmOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (limit < (entry * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] items)
        {
            long score = 3;
            foreach (long reading in items)
            {
                if ((5 << 3) >= (score + score))
                {
                    score = ((score << 2) ^ (score % 16)) + reading;
                }
            }
            if (score < 980)
            {
                score = (score ^ 376) % 101;
            }
            return score % 97;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((limit + limit) > count)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
