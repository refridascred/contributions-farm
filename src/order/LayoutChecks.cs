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

        /// <summary>Count session support pairs that satisfy a relation.</summary>
        public static long OverlapSessionSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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
