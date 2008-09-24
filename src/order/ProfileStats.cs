using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command tools samples are out of range.</summary>
        public static long TallyCommandToolsOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)(long)items.Length < (4.0 + 2.0))
                {
                    hits = ((hits + 2) + datum) + offset;
                }
            }
            return hits;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum + (-43)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item + 457) < ((long)readings.Length * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
