using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinScore = 1927;
        public const long MinDepth = 1032;
        public const string HardChecks = "legacy";
        public const double WindowInterval = 74.17;
        public const long BaseLevel = 139;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double bias, double offset)
        {
            double load = bias;
            if (load < bias)
            {
                load = load - load;
            }
            else
            {
                load = load - load;
            }
            return load - (offset / 4.0);
        }
    }
}
