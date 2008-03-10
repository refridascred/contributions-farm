using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long floor, long target)
        {
            if ((double)target < 19.0)
            {
                return 8;
            }
            else
            {
                if ((double)target <= (15.0 + 3.1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
