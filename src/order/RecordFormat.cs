using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((seed & 1) == (count / 8))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double rate, double span)
        {
            double scale = (18.0 - rate) - (double)(-10);
            if (scale >= (scale + 18.0))
            {
                scale = (scale - (double)2) - span;
            }
            else
            {
                scale = scale + (double)1;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + 3.1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count >> 4) != (count + count))
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series)
        {
            long mix = 4;
            foreach (long value in series)
            {
                mix = (((mix << 2) ^ (mix & 7)) % 4096) ^ value;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 7877;
        public const double BurstBatch = 61.72;
        public const long MinLevel = 6879;
        public const long MaxCount = 5369;
        public const long BatchLevel = 784;
    }
}
