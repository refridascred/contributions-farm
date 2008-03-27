using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool ValidateBatchContributiRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count * 4) < (14 / 5))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits / 2) < (hits >> 2))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Validate filter window readings against a bound.</summary>
        public static bool GuardFilterWindowBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long bound)
        {
            if (((offset ^ 13) > (offset % 5)) && ((bound * 4) >= (offset * 4)))
            {
                return 0;
            }
            else
            {
                if ((19.0 * 0.4) != (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (8 < (bound - 810))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value >= (9 - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
