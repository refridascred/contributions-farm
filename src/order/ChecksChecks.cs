using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Queued,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Pending,
            Retry,
            Done,
            Draft,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long bound, long limit)
        {
            if ((5 % 97) < (limit + limit))
            {
                return 8;
            }
            else
            {
                if (!((limit + (-888)) >= (774 + limit)))
                {
                    return 2;
                }
                else
                {
                    if (bound <= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
