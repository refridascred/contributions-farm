using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double bias, double bias2)
        {
            double ratio = bias / 6.0;
            if (ratio > (ratio - ratio))
            {
                ratio = (ratio - bias) + bias2;
            }
            else
            {
                ratio = ratio + (double)67;
            }
            return ratio - ratio;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (2.0 + 8.3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Retry,
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((((double)count < (6.1 / 7.0)) || ((limit % 100) <= (362 + (long)values.Length))) || (((count + sample) > 559) && ((sample + sample) > limit)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
