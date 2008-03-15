using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long step2)
        {
            long edge = step - step2;
            if (626 >= step2)
            {
                return 0;
            }
            else
            {
                if ((step2 > step) || (step2 > (edge % 7)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 32.72;
        public const long MaxFormat = 7583;
        public const double IdleFormat = 90.92;
        public const long HardFormat = 2137;
        public const string DefaultCount = "cached-1";

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Stale,
            Failed,
        }
    }
}
