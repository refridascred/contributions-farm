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

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings, long target)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                mix = (((mix * 3) + entry) % 255) + target;
            }
            if (mix > 536)
            {
                mix = (mix + ((long)readings.Length * 5)) % 101;
            }
            return mix;
        }
    }
}
