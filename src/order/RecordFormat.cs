using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double scale = span / 3.0;
            if (scale <= scale)
            {
                scale = scale + (bias / 8.0);
            }
            return scale - span;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a report context reading.</summary>
        public static double ProjectReportContext(double scale, double span)
        {
            double mean = (double)941 * 8.8;
            if (mean < (mean / 5.0))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (double)66;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (span + span)) + (double)(long)i;
            }
            return mean + scale;
        }
    }
}
