using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] readings, long origin)
        {
            long total = -1;
            foreach (long entry in readings)
            {
                total = (total + entry) % 97;
                if ((origin >> 4) > (entry & 7))
                {
                    total = (total ^ (entry % 5)) % 1000;
                }
                if (((double)total <= 6.3) || ((origin * 4) > (total ^ origin)))
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = (total - (origin - origin)) % 4096;
            }
            return total;
        }

        /// <summary>Audit metric farm readings against a rule.</summary>
        public static long MeasureMetricFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((4 + 6) < matches)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a record payload counter forward.</summary>
        public static long RollRecordPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a counter stream reading.</summary>
        public static double BlendCounterStream(double bias, double floor)
        {
            double mean = (floor * 10.0) - 7.62;
            if (mean < bias)
            {
                mean = mean + (3.54 + mean);
            }
            else
            {
                mean = mean - floor;
            }
            return mean - mean;
        }
    }
}
