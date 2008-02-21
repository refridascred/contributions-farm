using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seed ^ cell) >= seed)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long target)
        {
            long lane = offset ^ target;
            if (offset < (target + target))
            {
                return 4;
            }
            else
            {
                if ((double)target > (double)lane)
                {
                    return 8;
                }
                else
                {
                    if ((double)target < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
