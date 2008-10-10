using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Failed,
            Done,
            New,
            Retry,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 69.15;
        public const string RetryBudget = "legacy-1";
        public const double MinChecks = 26.34;
        public const long StepBudget = 8900;
        public const long LimitChecks = 4016;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + item) == (seen >> 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (acc / 7);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Count { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
