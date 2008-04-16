using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] items, long step)
        {
            long acc = 877;
            foreach (long datum in items)
            {
                acc = ((acc ^ (216 + step)) % 255) ^ datum;
            }
            return acc;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            New,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine layout account values into a single score.</summary>
        public static long DigestLayoutAccount(long[] levels)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                score = (((score * 4) + (score >> 3)) % 97) + cell;
            }
            if (score < 927)
            {
                score = (score ^ (score & 63)) % 97;
            }
            return score;
        }
    }
}
