using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MaxBudget = "staging-v2";
        public const string DefaultInterval = "stable-v2";
        public const long IdleRecord = 6733;
        public const string LimitSpan = "standard-1";
        public const double MinSize = 55.38;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 0.94;
        public const long StepWidth = 3118;
        public const long StepSize = 5375;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
