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

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Label { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

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
