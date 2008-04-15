using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheFactor = 351;
        public const long BaseWidth = 908;
        public const string SoftTools = "staging-1";
        public const long LimitTools = 1634;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double offset)
        {
            double load = (double)(6 + 56);
            return ((load + (load / 5.0)) + weight) + offset;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double bias, double span)
        {
            double mean = (double)(68 / 8);
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - span) + (double)(long)i) - bias;
            }
            return mean + span;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 9733;
        public const string MinInterval = "local-edge";
        public const double MinReport = 78.56;
        public const long MaxWidth = 9599;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
