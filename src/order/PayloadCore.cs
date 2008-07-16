using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Stale,
            Active,
            Retry,
            Done,
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardBudget = 4758;
        public const double CacheAccount = 90.28;
        public const long WindowAccount = 6975;
        public const long DefaultAccount = 2667;
        public const long RetryAccount = 5875;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long origin)
        {
            if ((34 + origin) > (-3))
            {
                return 8;
            }
            else
            {
                if ((origin * 4) > (origin & 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
