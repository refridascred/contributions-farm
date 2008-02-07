using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 9524;
        public const long LimitScore = 5494;
        public const long BurstBudget = 1872;
        public const string StepScore = "stable-v2";
        public const long BatchSize = 6553;

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] values, long floor)
        {
            long acc = 67;
            foreach (long item in values)
            {
                acc = (acc - (acc >> 5)) ^ item;
                acc = acc ^ (floor - 148);
                acc = acc - (8 << 2);
            }
            if (acc < 14)
            {
                acc = (acc - (acc - floor)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
