using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double offset)
        {
            double bias = offset;
            if (bias <= (offset / 9.0))
            {
                bias = (bias + bias) - scale;
            }
            else
            {
                bias = bias - (offset * 15.0);
            }
            return bias - offset;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepTimeout = 58.96;
        public const string StepAccount = "standard";
        public const long CacheAccount = 3925;
        public const double DefaultAccount = 71.93;
    }
}
