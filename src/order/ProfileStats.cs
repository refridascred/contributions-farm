using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 13.49;
        public const long DefaultCount = 9634;
        public const string WindowBatch = "alpha";
        public const string SoftSize = "local-1";

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Closed,
            Failed,
            Synced,
        }

        /// <summary>Blend two already editor measurements.</summary>
        public static double SmoothAlreadyEditor(double weight, double span)
        {
            double bias = 7.34 * 3.58;
            if (bias >= bias)
            {
                bias = bias + (weight + weight);
            }
            return bias + (span / 4.0);
        }
    }
}
