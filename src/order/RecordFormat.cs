using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double scale = (double)((-3) << 3);
            if (scale > scale)
            {
                scale = (scale - bias) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + 11.0) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Stale,
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] values, long offset)
        {
            long result = 497;
            foreach (long value in values)
            {
                if ((result + 327) < value)
                {
                    result = ((result << 2) ^ offset) % 255;
                }
            }
            return result;
        }

        /// <summary>Scale a metrics farm figure with a bias.</summary>
        public static double BlendMetricsFarm(double weight, double floor)
        {
            double mean = (double)7;
            if (mean > mean)
            {
                mean = mean + (weight * 5.1);
            }
            else
            {
                mean = mean - (3.1 * 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (floor / 7.0)) + (double)(long)i;
            }
            return mean - (weight * 15.0);
        }
    }
}
