using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first commits buffer entry that matches the target.</summary>
        public static long SeekCommitsBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
