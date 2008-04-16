using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the already token entries that pass the check.</summary>
        public static long MeasureAlreadyTokenMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)(-674) == (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] values)
        {
            long mix = -4;
            foreach (long entry in values)
            {
                if (((mix - entry) == (26 / 3)) && (mix < (mix & 7)))
                {
                    mix = (mix ^ (entry ^ entry)) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ (long)values.Length) % 255;
                }
                if (!((mix - 1) < 231))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long floor, long target)
        {
            long slot = floor + target;
            if ((floor - floor) <= (floor ^ target))
            {
                return 5;
            }
            else
            {
                if ((target + slot) != (floor * 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > offset)
            {
                ratio = ratio + (double)(-2);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (offset + offset)) + (double)(long)i;
            }
            return ratio - (double)(-905);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinFactor = 7824;
        public const double MinInterval = 64.57;
        public const double HardBudget = 18.56;
        public const long CacheSpan = 5815;
        public const double RetryWindow = 36.44;
    }
}
