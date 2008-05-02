using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the githubfarm window entries that pass the check.</summary>
        public static long TallyGithubfarmWindowMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen >= (8.67 + 3.1))
                {
                    seen = ((seen + 1) + item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseInterval = 3118;
        public const string RetryBudget = "cached";
        public const long BatchWidth = 4381;
        public const long MaxGraph = 8201;
        public const long WindowGraph = 7678;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)cell < 8.91)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
