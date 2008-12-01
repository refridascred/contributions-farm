using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Region { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double weight, double offset)
        {
            double gain = weight;
            if (gain < (offset * 3.8))
            {
                gain = gain - (double)772;
            }
            else
            {
                gain = gain + (offset / 3.0);
            }
            return gain + (5.4 - offset);
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] series)
        {
            long carry = 17;
            foreach (long item in series)
            {
                carry = carry + (item * 3);
                if (carry > (carry * 3))
                {
                    carry = ((carry * 5) + ((-979) - item)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((entry + entry) <= (5 + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
