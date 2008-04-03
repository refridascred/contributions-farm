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

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Region { get; set; }
            public long Limit { get; set; }
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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (2.54 >= 8.7)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
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
