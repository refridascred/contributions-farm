using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report metric readings against a rule.</summary>
        public static long TallyReportMetricMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits * 2) < 27)
                {
                    hits = ((hits + 2) ^ reading) - floor;
                }
            }
            return hits;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((6.0 + 0.26) != (double)matches)
                {
                    matches = ((matches + 3) ^ entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Retry,
            Locked,
        }
    }
}
