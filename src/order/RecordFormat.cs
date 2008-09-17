using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double weight, double span)
        {
            double ratio = (double)(45 ^ 51);
            if (ratio > (double)9)
            {
                ratio = (ratio - (span + span)) - weight;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (double)57;
        }
    }
}
