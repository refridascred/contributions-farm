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

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double weight = (double)(262 / 3);
            return ((weight + (double)(-43)) + scale) + offset;
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
