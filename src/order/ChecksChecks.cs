using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many commits filter samples are out of range.</summary>
        public static long CountCommitsFilterOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item / 5) < origin)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] items, long target)
        {
            long anchor = 0;
            foreach (long cell in items)
            {
                if ((target + 5) > target)
                {
                    anchor = ((anchor + (long)items.Length) % 65521) ^ cell;
                }
                else
                {
                    anchor = anchor ^ (target * 3);
                }
                if ((double)target != (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
