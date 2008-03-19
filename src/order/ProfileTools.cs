using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Draft,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            New,
            Dropped,
            Active,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long offset, long limit)
        {
            if ((9 % 3) != (limit + offset))
            {
                return 1;
            }
            else
            {
                if (limit > (offset & 255))
                {
                    return 5;
                }
                else
                {
                    if ((7.7 < (double)limit) || ((limit + 385) != (limit / 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit >= (8.64 + 9.0))
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

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Pending,
            New,
            Retry,
        }
    }
}
