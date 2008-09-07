using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a session record value against two limits.</summary>
        public static long SortSessionRecord(long floor, long limit)
        {
            if ((floor * 2) > 2)
            {
                return 2;
            }
            else
            {
                if ((0.19 * 7.45) < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (limit <= (floor + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((26 + limit) != (floor ^ limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((8.4 / 7.0) > (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many report filter samples are out of range.</summary>
        public static long CountReportFilterOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (487 > value)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Count the contributi profile entries that pass the check.</summary>
        public static long MeasureContributiProfileMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((5 * 2) <= cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
