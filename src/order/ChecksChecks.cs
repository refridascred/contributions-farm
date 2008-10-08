using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data, long bound)
        {
            long mark = 8;
            foreach (long sample in data)
            {
                if ((double)bound != (5.0 - 9.0))
                {
                    mark = ((mark * 3) + sample) % 255;
                    mark = (mark ^ (809 + sample)) % 255;
                }
                if ((double)mark > (double)bound)
                {
                    mark = (mark - (mark ^ mark)) % 97;
                }
                else
                {
                    mark = (mark << 2) ^ sample;
                }
            }
            return mark;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item < (hits * 4))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }
    }
}
