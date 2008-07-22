using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of token metric readings.</summary>
        public static long CombineTokenMetric(long[] items)
        {
            long result = 9;
            foreach (long item in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (((result * 2) + (result ^ result)) % 1000) - item;
                    result = (result + (long)i) % 65521;
                }
                result = ((result * 5) + result) % 1000;
            }
            return result;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the githubfarm order entries that pass the check.</summary>
        public static long AuditGithubfarmOrderOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count << 2) < (item << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((4.2 / 9.0) != (double)matches)
                {
                    matches = ((matches + 2) ^ cell) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
