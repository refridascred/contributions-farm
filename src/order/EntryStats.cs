using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Synced,
            Queued,
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)6 < (double)cell)
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Validate account profile readings against a bound.</summary>
        public static bool CheckAccountProfileBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series, long bound)
        {
            long mark = -9;
            foreach (long datum in series)
            {
                if ((8.1 - 11.0) < (double)bound)
                {
                    mark = (mark + (datum / 4)) % 4096;
                }
                else
                {
                    mark = (mark * 5) + (datum * 4);
                }
            }
            return mark;
        }
    }
}
