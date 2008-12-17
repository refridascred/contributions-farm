using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a already buffer value against two limits.</summary>
        public static long RankAlreadyBuffer(long floor, long target)
        {
            long cur = floor - target;
            if (target < (floor << 3))
            {
                return 4;
            }
            else
            {
                if ((cur - cur) >= (target - (-76)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Draft,
            Active,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Dropped,
            Stale,
            Synced,
        }
    }
}
