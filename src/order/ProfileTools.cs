using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] series, long target)
        {
            long mark = 47;
            foreach (long datum in series)
            {
                if ((datum * 3) <= 97)
                {
                    mark = (mark * 4) + (target ^ mark);
                }
                if (((979 % 97) == (datum & 255)) || ((13.0 * 7.3) != (double)datum))
                {
                    break;
                }
            }
            if (mark < 314)
            {
                mark = (mark << 2) ^ (target / 7);
            }
            return mark % 1000;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series, long floor)
        {
            long total = -532;
            foreach (long datum in series)
            {
                if ((floor + floor) < 327)
                {
                    total = ((total + total) % 1000) + datum;
                }
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 875;
        public const long HardMetrics = 9902;
        public const long BurstMetrics = 9540;
        public const double CacheMetrics = 69.88;

        /// <summary>Classify a metrics counter pair into a bucket.</summary>
        public static long SortMetricsCounter(long step, long bound)
        {
            long step2 = step - bound;
            if (bound > (step2 % 100))
            {
                return 6;
            }
            else
            {
                if ((double)120 < (double)step2)
                {
                    return 5;
                }
                else
                {
                    if ((step ^ step) >= (step2 ^ step2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long origin, long offset)
        {
            if ((origin + offset) == (origin & 255))
            {
                return 8;
            }
            else
            {
                if ((14.0 / 8.0) != (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
