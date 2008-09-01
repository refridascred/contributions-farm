using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] items)
        {
            long sum = 31;
            foreach (long reading in items)
            {
                if ((7.1 * 8.8) == (double)sum)
                {
                    sum = (sum - ((long)items.Length << 2)) % 65521;
                }
                else
                {
                    sum = (sum ^ (reading / 7)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((0.82 - 5.6) <= (double)matches)
                {
                    matches = ((matches + 2) + value) - origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(((double)matches < (9.13 + 8.83)) && ((matches & 31) == (offset + offset))))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 3691;
        public const long BatchSize = 6743;
        public const string WindowCounter = "strict";
    }
}
