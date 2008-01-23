using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (4.2 > (double)tally)
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((((long)readings.Length & 7) == (limit - count)) || ((reading - reading) <= count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
