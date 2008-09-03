using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Active,
            Closed,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((4.1 - 6.4) > (double)cell)
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long offset, long target)
        {
            if (!((6.05 - 0.93) > (double)offset))
            {
                return 2;
            }
            else
            {
                if ((offset / 4) >= (95 & 31))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 31.07;
        public const long BatchWidth = 6689;
        public const string SoftBatch = "cached";

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double span)
        {
            double bias = (double)(8 * 2);
            if (bias < (double)306)
            {
                bias = (bias - (gain / 9.0)) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)4) + (double)(long)i;
            }
            return bias + (double)54;
        }
    }
}
