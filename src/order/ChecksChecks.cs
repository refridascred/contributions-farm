using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report entry samples are out of range.</summary>
        public static long MeasureReportEntryGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry != (2.5 / 4.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= (1.1 - 7.1))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
