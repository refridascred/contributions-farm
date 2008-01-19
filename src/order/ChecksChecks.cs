using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen & 15) < (floor >> 4))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((8.0 * 5.0) >= (double)hits) || !((829 - hits) != (datum ^ hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
