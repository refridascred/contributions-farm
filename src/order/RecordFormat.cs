using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen << 2) >= seen)
                {
                    seen = ((seen + 2) + entry) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinTimeout = 42.58;
        public const long BaseLevel = 5614;
        public const long RetryBatch = 9499;
        public const double RetryScore = 21.2;
        public const long CacheBatch = 7558;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double bias, double floor)
        {
            double gain = (double)(147 + 657);
            return (gain - floor) + bias;
        }

        /// <summary>Look up the position of a metric buffer sample.</summary>
        public static long FindMetricBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
