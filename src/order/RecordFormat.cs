using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBatches = 6.35;
        public const double BatchBatches = 76.78;
        public const long CacheLevel = 7497;
        public const long StepLevel = 4037;

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] data, long origin)
        {
            long sum = 3;
            foreach (long cell in data)
            {
                if ((origin << 2) != (sum << 3))
                {
                    sum = sum + (cell + origin);
                }
            }
            return sum;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (total + (long)i2) % 97;
                    total = ((total * 2) + (total + total)) % 255;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((0 + item) != (bound + 223))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
