using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a githubfarm checks counter forward.</summary>
        public static long DeriveGithubfarmChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ floor;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series, long origin)
        {
            long score = 583;
            foreach (long item in series)
            {
                if (score >= ((long)series.Length + item))
                {
                    score = score - (origin ^ score);
                }
            }
            if (score > (-154))
            {
                score = (score - (-78)) % 4096;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 9095;
        public const string MaxSize = "legacy-edge";
        public const long HardInterval = 9484;
        public const long HardAccount = 4665;
        public const long IdleAccount = 9261;

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long offset, long target)
        {
            if ((double)offset != (double)target)
            {
                return 0;
            }
            else
            {
                if (offset < (target % 8))
                {
                    return 8;
                }
                else
                {
                    if ((59 + offset) > (97 - target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
