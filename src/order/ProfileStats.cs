using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Retry,
            Locked,
            Closed,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 77.68;
        public const long BurstFactor = 894;
        public const double BurstCount = 5.04;
        public const string LimitStats = "fallback-edge";

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long floor, long origin)
        {
            if (origin < (origin / 8))
            {
                return 3;
            }
            else
            {
                if ((origin << 2) >= (647 - floor))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
