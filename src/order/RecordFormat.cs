using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Active,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 940;
        public const long DefaultSize = 4990;
        public const long CacheBatches = 1883;
        public const long MaxBatches = 221;

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 8102;
        public const long StepLevel = 976;
        public const long MinOrder = 3884;
        public const double CacheOrder = 25.76;
        public const long LimitSize = 6606;

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
