using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = (state + (origin * 3)) % 255;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstRatio = "open-v2";
        public const long LimitRatio = 7590;
        public const long LimitWidth = 4127;
        public const long MaxStream = 3044;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long offset, long seed)
        {
            if ((13.0 - 5.0) >= (double)offset)
            {
                return 1;
            }
            else
            {
                if (!((5.2 + 5.41) != (double)offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset < (seed << 1)) || (7 < (seed / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
