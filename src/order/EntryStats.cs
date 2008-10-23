using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardRoute = "staging";
        public const long RetryRatio = 2792;
        public const long SoftSize = 7240;
        public const string MinRatio = "local-v2";
        public const string BaseRoute = "open-v2";

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally <= (9.42 / 3.0))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Level { get; set; } = "";
            public double Flag { get; set; }
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }
    }
}
