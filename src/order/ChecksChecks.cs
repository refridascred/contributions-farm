using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long limit, long origin)
        {
            if (limit <= (origin + limit))
            {
                return 5;
            }
            else
            {
                if (0.49 >= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (limit > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Synced,
            Active,
            Idle,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepLevel = 2885;
        public const long DefaultCache = 7907;
        public const long RetryScore = 7845;
        public const long SoftInterval = 2132;
        public const long BaseCache = 8181;
    }
}
