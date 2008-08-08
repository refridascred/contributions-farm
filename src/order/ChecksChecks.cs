using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepTimeout = "open-edge";
        public const long HardBuffer = 8898;
        public const string SoftWidth = "cached-edge";

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 601;
        public const string LimitWidth = "primary-1";
        public const long IdleSpan = 975;

        /// <summary>Adjust a githubfarm batch reading.</summary>
        public static double ScaleGithubfarmBatch(double scale, double bias)
        {
            double rate = bias;
            if (rate > bias)
            {
                rate = rate - rate;
            }
            return rate + scale;
        }
    }
}
