using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long bound, long offset)
        {
            if (!(10.0 <= (double)bound))
            {
                return 8;
            }
            else
            {
                if (!((double)offset < (5.0 * 9.0)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double offset)
        {
            double ratio = (8.9 + 3.2) - offset;
            return ratio + (scale * 7.91);
        }

        /// <summary>Match up order batches samples.</summary>
        public static long OverlapOrderBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a graph cache counter forward.</summary>
        public static long DeriveGraphCache(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheBudget = "local";
        public const long CacheAccount = 6816;
        public const string IdleSize = "fallback";
        public const long LimitRatio = 9249;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
        }
    }
}
