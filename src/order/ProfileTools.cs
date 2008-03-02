using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "cached-edge";
        public const long BatchSchema = 8166;
        public const long IdleScore = 2739;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Draft,
            Dropped,
            Queued,
        }

        /// <summary>Classify a cache githubfarm pair into a bucket.</summary>
        public static long ClassifyCacheGithubfarm(long limit, long step)
        {
            if (3 >= (step + step))
            {
                return 2;
            }
            else
            {
                if (5.8 > (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit * 2) >= step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
