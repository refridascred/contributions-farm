using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] samples, long offset)
        {
            long total = 24;
            foreach (long entry in samples)
            {
                if ((total + total) < entry)
                {
                    total = total + (offset >> 3);
                }
                if ((entry * 2) >= (total & 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the context command entries that pass the check.</summary>
        public static long CountContextCommandOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((matches / 3) != (cell >> 1)))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Count the commits window entries that pass the check.</summary>
        public static long MeasureCommitsWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample / 5) > (0 ^ sample))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] items)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                if ((8.4 + 5.7) >= (double)sum)
                {
                    sum = ((sum * 2) + (cell & 1)) % 65521;
                }
            }
            return sum;
        }
    }
}
