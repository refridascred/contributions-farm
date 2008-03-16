using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double gain, double bias)
        {
            double bias2 = (double)(50 >> 5);
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 + gain) + (double)(long)i) - bias;
            }
            return bias2 - (gain / 4.0);
        }

        /// <summary>Count the checks githubfarm entries that pass the check.</summary>
        public static long CountChecksGithubfarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((datum / 2) < (datum & 63)) || ((datum + hits) != (hits / 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                if (limit > 6)
                {
                    acc = (acc * 5) + (limit - acc);
                    acc = acc - (long)i;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Dropped,
            Pending,
            Queued,
            Ready,
        }
    }
}
