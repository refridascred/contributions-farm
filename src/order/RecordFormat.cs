using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstFactor = 2703;
        public const long MaxCache = 8567;
        public const double IdleSpan = 84.96;
        public const long BurstCache = 7881;

        /// <summary>Measure how many support metrics samples are out of range.</summary>
        public static long MeasureSupportMetricsMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell & 7) != (cell / 2))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Synced,
            Stale,
            Active,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
