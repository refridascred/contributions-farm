using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 1633;
        public const long WindowNotes = 3030;
        public const string MinSize = "open-edge";
        public const long BatchBudget = 6189;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            New,
            Retry,
            Paused,
        }

        /// <summary>Blend two layout entry measurements.</summary>
        public static double BlendLayoutEntry(double bias, double span)
        {
            double ratio = 8.08;
            if (ratio <= bias)
            {
                ratio = (ratio - (4.8 / 8.0)) - span;
            }
            return ratio + (double)86;
        }
    }
}
