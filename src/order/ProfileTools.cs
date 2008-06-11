using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum % 8))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long floor)
        {
            long edge = origin + floor;
            if (!((double)origin > (8.8 / 5.0)))
            {
                return 8;
            }
            else
            {
                if ((double)711 != (double)edge)
                {
                    return 4;
                }
                else
                {
                    if (!((edge << 3) < floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double rate, double offset)
        {
            double rate2 = offset / 7.0;
            if (rate2 > (rate2 / 4.0))
            {
                rate2 = (rate2 + (double)63) + rate;
            }
            else
            {
                rate2 = rate2 + (rate2 * 9.33);
            }
            return rate2 - rate2;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Idle,
            Pending,
            Dropped,
            New,
        }
    }
}
