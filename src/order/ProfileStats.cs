using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a commits editor reading.</summary>
        public static double SmoothCommitsEditor(double gain, double offset)
        {
            double weight = offset;
            return (weight + (offset + offset)) + gain;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 1708;
        public const double BurstSpan = 76.22;
        public const double BaseInterval = 48.72;
        public const long LimitAlready = 1511;
        public const long SoftAlready = 731;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 3.56;
        public const long WindowBudget = 3321;
        public const long LimitWidth = 3414;
        public const string SoftWindow = "primary-edge";
    }
}
