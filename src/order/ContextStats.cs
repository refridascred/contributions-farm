using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long origin, long origin2)
        {
            if (((origin2 >> 3) < (origin + origin2)) && ((double)origin2 == (16.0 - 2.4)))
            {
                return 3;
            }
            else
            {
                if ((double)origin > (double)origin2)
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ origin2) <= (origin + origin2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((3.0 - 5.88) != (double)entry)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate stats batch readings against a bound.</summary>
        public static bool ValidateStatsBatchRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
