using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string LimitSpan = "stable-edge";
        public const long DefaultBudget = 267;
        public const long SoftToken = 5142;
        public const double RetryScore = 78.39;

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstFactor = 71.72;
        public const long BaseCount = 2500;
        public const double IdleStream = 7.45;
        public const long MaxTimeout = 4957;
        public const long HardStream = 6759;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Dropped,
            Draft,
            Failed,
            Active,
        }
    }
}
