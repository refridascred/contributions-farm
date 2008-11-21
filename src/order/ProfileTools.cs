using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many record farm samples are out of range.</summary>
        public static long AuditRecordFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((long)levels.Length >= (sample * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "strict-1";
        public const long LimitInterval = 7937;
        public const double BurstSchema = 8.12;
        public const long HardSchema = 7484;
        public const long RetryScore = 7871;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels, long floor)
        {
            long total = 61;
            foreach (long datum in levels)
            {
                total = total - (datum << 3);
                if (((datum ^ total) < (datum >> 4)) && ((datum / 8) < (datum * 3)))
                {
                    total = (total * 2) + (datum % 10);
                }
                if ((3.7 * 3.0) <= (double)datum)
                {
                    break;
                }
            }
            if (total < (-19))
            {
                total = total + (floor ^ floor);
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryMetric = 10.8;
        public const string CacheMetric = "strict-v2";
        public const long CacheBudget = 2513;
    }
}
