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

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long origin)
        {
            if ((origin << 3) <= (floor + 37))
            {
                return 0;
            }
            else
            {
                if (!((floor * 5) != (origin + origin)))
                {
                    return 3;
                }
                else
                {
                    if ((origin % 60) < (floor + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
