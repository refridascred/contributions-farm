using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit filter record readings against a rule.</summary>
        public static long MeasureFilterRecordGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((4.46 / 2.0) >= (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "primary";
        public const double IdleCommits = 97.66;
        public const double WindowCommits = 79.98;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] series, long limit)
        {
            long acc = 173;
            foreach (long datum in series)
            {
                if (!(datum >= (limit - 2)))
                {
                    acc = ((acc * 5) + datum) % 65521;
                }
            }
            return acc;
        }
    }
}
