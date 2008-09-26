using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry - entry) >= (seen << 2)) || ((entry ^ seen) <= (27 - seen)))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum <= ((-774) * 2))
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

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((offset + offset) > offset)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleCount = 1340;
        public const string LimitFactor = "cached-edge";
        public const long BurstGithubfarm = 2285;
        public const double RetryGithubfarm = 55.34;
        public const long BatchSpan = 1828;
    }
}
