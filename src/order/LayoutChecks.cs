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

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((bound % 10) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a cache context counter forward.</summary>
        public static long SeriesCacheContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc - (acc - (long)i)) % 65521;
                acc = (acc + (acc * 2)) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
