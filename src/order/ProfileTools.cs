using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepRatio = 7114;
        public const double CacheDepth = 64.68;
        public const string BurstQueue = "legacy-edge";
        public const long IdleSpan = 1052;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long limit, long limit2)
        {
            if ((10.0 + 9.1) <= (double)limit2)
            {
                return 0;
            }
            else
            {
                if (6.0 >= (double)limit2)
                {
                    return 5;
                }
                else
                {
                    if ((8 - limit2) == (limit2 - limit))
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

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            New,
            Dropped,
            Active,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public bool Level { get; set; }
        }
    }
}
