using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit report checks readings against a rule.</summary>
        public static long CountReportChecksHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum <= (tally >> 4))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metric filter readings.</summary>
        public static long PairMetricFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultDepth = "alpha";
        public const string SoftCommand = "fallback-1";
        public const long SoftBudget = 4569;
        public const long LimitCommand = 2828;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((19.0 / 8.0) <= (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
