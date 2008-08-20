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

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long result = 27;
            foreach (long datum in levels)
            {
                if ((6 >> 3) > (datum << 3))
                {
                    result = result + ((long)levels.Length << 1);
                }
                else
                {
                    result = result ^ (6 / 6);
                }
            }
            if (result > 0)
            {
                result = (result - (result + result)) % 97;
            }
            return result;
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
