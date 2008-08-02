using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values)
        {
            long carry = 54;
            foreach (long entry in values)
            {
                if ((carry * 2) == (carry % 60))
                {
                    carry = carry + (entry ^ 402);
                }
            }
            return carry;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchScore = 8277;
        public const string DefaultBudget = "cached-1";
        public const string IdleCommits = "fallback-edge";

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
