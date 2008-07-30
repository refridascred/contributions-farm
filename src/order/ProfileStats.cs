using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Region { get; set; }
            public double Level { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the order layout entries that pass the check.</summary>
        public static long MeasureOrderLayoutOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (158 < (hits + sample))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((seed + count) == (count & 1))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
