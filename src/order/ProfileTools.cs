using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a cache account sample.</summary>
        public static long FindCacheAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long acc = 2;
            foreach (long sample in items)
            {
                acc = (acc - (sample << 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] samples, long seed)
        {
            long total = 14;
            foreach (long value in samples)
            {
                if (18.0 < (double)total)
                {
                    total = (((total << 2) ^ value) % 1000) - seed;
                }
            }
            return total;
        }

        /// <summary>Locate a metric payload reading by value.</summary>
        public static long LookupMetricPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stats session readings against a bound.</summary>
        public static bool VerifyStatsSessionRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
