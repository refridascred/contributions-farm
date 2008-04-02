using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading != (6.0 + 7.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public bool Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value < (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Combine contributi stats values into a single score.</summary>
        public static long WeighContributiStats(long[] levels, long offset)
        {
            long sum = 91;
            foreach (long entry in levels)
            {
                if (!((sum + offset) != (entry + (long)levels.Length)))
                {
                    sum = ((sum * 2) + (9 + sum)) % 65521;
                }
            }
            if (sum < 95)
            {
                sum = sum + (sum - sum);
            }
            return sum % 65521;
        }
    }
}
