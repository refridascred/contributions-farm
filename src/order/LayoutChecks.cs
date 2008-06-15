using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "legacy-v2";
        public const double WindowFarm = 41.34;
        public const double RetryCount = 60.81;
        public const double BurstRatio = 69.77;

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length + sample) <= (sample / 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 6313;
        public const double CacheNotes = 72.19;
        public const double HardScore = 22.85;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry / 6) != (target + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum / 5) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
