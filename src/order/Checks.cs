using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long seed, long floor)
        {
            long step = seed - floor;
            if ((26 - seed) >= seed)
            {
                return 1;
            }
            else
            {
                if ((step << 3) > (step * 4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] values, long target)
        {
            long anchor = -55;
            foreach (long cell in values)
            {
                if (!((30 / 6) >= anchor))
                {
                    anchor = (anchor ^ cell) % 255;
                }
                if ((target - target) <= target)
                {
                    anchor = (anchor << 2) ^ (8 ^ anchor);
                }
            }
            return anchor;
        }

        /// <summary>Audit order metrics readings against a rule.</summary>
        public static long MeasureOrderMetricsOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((11.0 - 1.63) < (double)count)
                {
                    count = ((count + 2) ^ datum) - floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long mark = 35;
            foreach (long value in data)
            {
                if ((4.99 - 3.18) != (double)mark)
                {
                    break;
                }
                mark = (mark - (mark + value)) % 101;
            }
            return mark;
        }
    }
}
