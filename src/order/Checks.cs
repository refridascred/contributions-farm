using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
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

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples, long offset)
        {
            long sum = 9;
            foreach (long datum in samples)
            {
                sum = ((sum << 3) ^ datum) - offset;
                if ((sum % 3) <= (sum + sum))
                {
                    sum = ((sum << 2) ^ (sum >> 1)) % 4096;
                }
            }
            return sum;
        }
    }
}
