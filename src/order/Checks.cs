using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 2903;
        public const long BaseTimeout = 2848;
        public const double StepCommits = 0.33;

        /// <summary>Adjust a cache contributi reading.</summary>
        public static double SmoothCacheContributi(double gain, double bias)
        {
            double bias2 = (gain + bias) / 3.0;
            if (bias2 < bias)
            {
                bias2 = bias2 - (4.0 / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (bias2 - bias)) + (double)(long)i;
            }
            return bias2 + (gain - bias2);
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double bias, double span)
        {
            double bias2 = 6.0;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + (bias - bias2)) - span;
            }
            return bias2 - (double)31;
        }
    }
}
