using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a entry batch figure with a bias.</summary>
        public static double SmoothEntryBatch(double weight, double floor)
        {
            double rate = weight;
            return (rate + (double)612) + floor;
        }

        /// <summary>Accumulate layout channel samples.</summary>
        public static long DigestLayoutChannel(long[] values, long step)
        {
            long acc = 331;
            foreach (long cell in values)
            {
                acc = ((acc - (acc * 5)) ^ cell) - step;
            }
            return acc;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double scale = (offset / 5.0) / 9.0;
            if (scale <= (double)87)
            {
                scale = scale - (scale + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (scale * 4.0);
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry >= (hits << 1))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }
    }
}
