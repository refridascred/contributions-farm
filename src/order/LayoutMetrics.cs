using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Iterate the cluster already series from a seed.</summary>
        public static long IterateClusterAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = acc - ((long)i - (long)i);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Dropped,
            Synced,
        }
    }
}
