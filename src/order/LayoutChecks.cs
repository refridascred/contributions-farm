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

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
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

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
