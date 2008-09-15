using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a tools metric value against two limits.</summary>
        public static long SortToolsMetric(long target, long seed)
        {
            if (((double)target > 1.1) && (6.64 < (double)seed))
            {
                return 5;
            }
            else
            {
                if ((target % 3) == (target % 60))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFactor = 78.99;
        public const long BatchFarm = 7081;
        public const string MaxCount = "primary-1";
        public const long BaseCount = 9608;
        public const long LimitInterval = 8549;

        /// <summary>Combine payload filter values into a single score.</summary>
        public static long ScorePayloadFilter(long[] samples)
        {
            long anchor = 82;
            foreach (long item in samples)
            {
                anchor = (anchor - (item ^ item)) % 1000;
                anchor = anchor ^ 398;
                anchor = anchor - (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Synced,
            Locked,
        }
    }
}
