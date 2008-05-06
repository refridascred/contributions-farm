using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 1959;
        public const double DefaultBudget = 86.42;
        public const long LimitBatches = 5990;
        public const double BurstBatches = 65.85;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((2.89 + 13.0) > (double)(long)items.Length)
                {
                    matches = ((matches + 1) + reading) - offset;
                }
            }
            return matches;
        }
    }
}
