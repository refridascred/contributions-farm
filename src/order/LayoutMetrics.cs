using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "cached-1";
        public const long RetryFactor = 5342;
        public const long LimitDepth = 6007;

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxSpan = 2582;
        public const long StepScore = 5388;
        public const long SoftRecord = 6477;
        public const string WindowCount = "latest-1";
        public const long MinBudget = 6822;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Locked,
            Failed,
        }
    }
}
