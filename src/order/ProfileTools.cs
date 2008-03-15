using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Retry,
            Dropped,
        }

        /// <summary>Iterate the stats format series from a seed.</summary>
        public static long SeriesStatsFormat(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] series)
        {
            long mark = 29;
            foreach (long value in series)
            {
                if (((double)value != (8.75 + 7.0)) && ((double)mark != (4.0 - 7.93)))
                {
                    mark = (mark + mark) % 4096;
                }
                if ((9.7 * 7.0) > 4.9)
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = ((mark * 2) + (mark - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)923 != (double)cell)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }
    }
}
