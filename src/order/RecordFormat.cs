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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((674 + count) < (sample - (long)series.Length)) && ((count - sample) <= (count * 5)))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
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
