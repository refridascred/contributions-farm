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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value > (883 ^ value)) || ((5.54 * 0.8) == (double)value)) || ((value >> 1) > (value + value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (10.0 <= (double)sample)
                {
                    hits = (hits + 2) - floor;
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
