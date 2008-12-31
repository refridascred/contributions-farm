using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] data, long limit)
        {
            long score = 4;
            foreach (long reading in data)
            {
                if (!((reading * 2) > (score >> 4)))
                {
                    score = (score + reading) % 101;
                }
            }
            if (score < 9)
            {
                score = (score * 3) + (10 - limit);
            }
            return score;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] samples, long step)
        {
            long acc = 69;
            foreach (long item in samples)
            {
                acc = ((acc * 3) + (35 + item)) % 65521;
            }
            if (acc > 89)
            {
                acc = (acc - (step ^ 888)) % 101;
            }
            return acc;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
