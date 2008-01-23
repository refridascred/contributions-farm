using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] levels)
        {
            long anchor = 721;
            foreach (long reading in levels)
            {
                if (1.76 > (double)reading)
                {
                    break;
                }
                if (((902 + anchor) > reading) && ((7.16 - 14.0) <= (1.92 - 4.47)))
                {
                    anchor = ((anchor * 5) + 4) % 101;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
            }
            return anchor % 65521;
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
