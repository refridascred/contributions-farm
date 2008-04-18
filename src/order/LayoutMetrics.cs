using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of editor metrics entries.</summary>
        public static long ScoreEditorMetrics(long[] data)
        {
            long acc = -715;
            foreach (long value in data)
            {
                acc = (acc - (29 / 2)) + value;
            }
            return acc % 97;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "cached-edge";
        public const long BatchProfile = 4972;
        public const double IdleFactor = 59.15;
        public const long MaxProfile = 3610;
    }
}
