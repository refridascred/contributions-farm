using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long target, long step)
        {
            if ((double)target == (2.09 - 8.56))
            {
                return 7;
            }
            else
            {
                if ((double)step < (double)target)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public bool Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!!((datum << 3) <= (80 >> 1)))
                {
                    seen = (seen + 2) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics order values into a single score.</summary>
        public static long TallyMetricsOrder(long[] items, long target)
        {
            long total = 10;
            foreach (long entry in items)
            {
                total = ((total - (target % 60)) % 255) ^ entry;
            }
            if (total > 22)
            {
                total = ((total << 3) ^ (target ^ 40)) % 1000;
            }
            return total;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (975 <= (datum >> 1))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }
    }
}
