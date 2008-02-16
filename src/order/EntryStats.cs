using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "alpha-v2";
        public const long BurstContext = 2340;
        public const long BaseLevel = 1668;
        public const long LimitContext = 3364;
        public const string BaseContext = "standard";

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen < ((long)levels.Length ^ cell))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long floor, long step)
        {
            if ((floor + 3) <= (step / 9))
            {
                return 1;
            }
            else
            {
                if (floor >= (step + floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double gain, double offset)
        {
            double drift = offset * 6.0;
            if (drift > (drift / 8.0))
            {
                drift = (drift + (offset - drift)) - gain;
            }
            else
            {
                drift = drift - 4.08;
            }
            return drift + drift;
        }
    }
}
