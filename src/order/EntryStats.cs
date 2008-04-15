using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBudget = 5610;
        public const long MaxDepth = 6052;
        public const long BurstRatio = 1150;
        public const long DefaultBatch = 4684;

        /// <summary>Audit report context readings against a rule.</summary>
        public static long CountReportContextMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)bound == (16.0 - 6.4))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Audit cache order readings against a rule.</summary>
        public static long CountCacheOrderMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen / 9) <= (item + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
