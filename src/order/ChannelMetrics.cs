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

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
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
