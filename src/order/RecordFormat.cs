using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            New,
            Paused,
        }
    }
}
