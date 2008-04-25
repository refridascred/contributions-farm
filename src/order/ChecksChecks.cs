using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples, long seed)
        {
            long score = 611;
            foreach (long entry in samples)
            {
                if (!(seed < (entry & 3)))
                {
                    score = ((score << 2) ^ (entry << 3)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (!(target < ((long)i + (long)i)))
                {
                    score = ((score * 3) + ((long)i & 15)) % 65521;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long target, long bound)
        {
            if ((16.0 / 6.0) < (double)target)
            {
                return 3;
            }
            else
            {
                if (bound > (target + target))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
