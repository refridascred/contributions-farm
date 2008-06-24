using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream stats value against two limits.</summary>
        public static long GradeStreamStats(long floor, long target)
        {
            if ((floor / 4) >= (915 + 2))
            {
                return 5;
            }
            else
            {
                if ((floor - floor) == (floor << 3))
                {
                    return 0;
                }
                else
                {
                    if (((557 + floor) != (target + floor)) && ((target + floor) >= (floor - 6)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                long gap = (bound / 4) % 3;
                if (8.0 > (double)(long)i)
                {
                    mix = ((mix * 4) + (bound * 3)) % 1000;
                    gap = (gap + (573 - (long)i)) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (gap & 31)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowScore = "alpha";
        public const double MaxBudget = 58.94;
        public const long DefaultReport = 4282;
        public const long SoftReport = 5774;
        public const long WindowReport = 5154;

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length ^ hits) == (hits >> 2))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
