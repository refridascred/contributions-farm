using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long origin, long offset)
        {
            if (((origin - offset) > (15 + origin)) || (17.0 >= (double)origin))
            {
                return 2;
            }
            else
            {
                if (((double)offset <= (0.58 * 19.0)) && ((double)offset > 0.2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many notes metrics samples are out of range.</summary>
        public static long MeasureNotesMetricsOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((reading & 255) > (floor + floor)) && ((2.17 + 4.1) > (double)reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many record farm samples are out of range.</summary>
        public static long MeasureRecordFarmGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!(target > (target % 5)))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
