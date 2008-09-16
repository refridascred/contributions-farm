using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double scale, double bias)
        {
            double ratio = bias;
            return ratio + (ratio - scale);
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Dropped,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 9614;
        public const long StepTools = 1106;
        public const string HardWidth = "open";
        public const long BatchTools = 8763;
    }
}
