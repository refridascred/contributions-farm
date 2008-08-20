using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Level { get; set; }
            public double Limit { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] series)
        {
            long score = 3;
            foreach (long cell in series)
            {
                score = ((score << 3) ^ ((long)series.Length + 357)) + cell;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitSpan = "alpha-edge";
        public const string DefaultChecks = "strict-edge";
        public const long BaseScore = 9943;
        public const long RetryChecks = 1305;
        public const long CacheBudget = 3149;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
