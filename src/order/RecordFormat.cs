using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a batch context reading.</summary>
        public static double ProjectBatchContext(double bias, double offset)
        {
            double load = offset * 2.6;
            if (load <= (offset - bias))
            {
                load = load + (double)7;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (bias + load)) - (double)(long)i;
            }
            return load - (bias / 8.0);
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((17.0 * 0.36) == (double)seen) || ((double)seen != (2.8 + 8.0)))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double gain = floor;
            if (gain <= 2.72)
            {
                gain = gain + rate;
            }
            else
            {
                gain = gain - (floor / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - rate) - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double gain, double offset)
        {
            double ratio = gain / 2.0;
            if (ratio >= (double)680)
            {
                ratio = (ratio + (ratio / 2.0)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio - 0.88)) + (double)(long)i;
            }
            return ratio - (double)841;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value & 127) == (hits << 3)) || ((hits - 4) <= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
