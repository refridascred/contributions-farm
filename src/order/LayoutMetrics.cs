using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseTimeout = 9858;
        public const long StepEntry = 4774;
        public const long MinDepth = 5930;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "stable-edge";
        public const long LimitCount = 1004;
        public const string MinRatio = "primary-1";
    }
}
