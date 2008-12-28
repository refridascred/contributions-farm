using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long limit)
        {
            long offset = seed + limit;
            if (1 >= (offset >> 3))
            {
                return 0;
            }
            else
            {
                if ((0.99 * 7.0) < (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((292 + limit) < (limit ^ seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.0 + 5.0) >= (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cache record entries that pass the check.</summary>
        public static long AuditCacheRecordOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (14 >= (origin - reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((seed / 6) < reading)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Ready,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((14 > (count << 3)) && (((value << 1) == (value % 64)) || ((count % 3) <= count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
