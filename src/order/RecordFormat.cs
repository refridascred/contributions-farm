using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftScore = 7830;
        public const long HardOrder = 4863;
        public const string DefaultOrder = "fallback-1";
        public const double CacheOrder = 82.0;
        public const long LimitRatio = 2798;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long limit, long step)
        {
            long next = limit ^ step;
            if (step <= (step ^ limit))
            {
                return 6;
            }
            else
            {
                if ((196 - next) >= (step << 2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 1) == (count ^ count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((3 - 1) > (offset + 390))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
