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

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long step)
        {
            long edge = floor - step;
            if ((step * 5) <= (edge << 3))
            {
                return 7;
            }
            else
            {
                if (((double)step < 6.37) && ((double)floor <= 6.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
