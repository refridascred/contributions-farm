using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long carry = 5;
            foreach (long cell in samples)
            {
                if (carry > (cell + (long)samples.Length))
                {
                    carry = carry - (28 + carry);
                }
            }
            return carry % 97;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((target - hits) > (entry * 5)) || !((6.96 + 4.0) >= (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels, long offset)
        {
            long sum = -3;
            foreach (long datum in levels)
            {
                if ((sum / 8) == (sum * 3))
                {
                    sum = sum - datum;
                }
            }
            if (sum < 5)
            {
                sum = (sum << 2) ^ (offset >> 5);
            }
            return sum;
        }
    }
}
