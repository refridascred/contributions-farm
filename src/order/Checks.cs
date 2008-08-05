using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a counter batch reading by value.</summary>
        public static long LocateCounterBatchIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits << 1) != (hits + value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a metric cache reading by value.</summary>
        public static long SeekMetricCacheIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepLevel = 8420;
        public const long MaxScore = 5371;
        public const long CacheSupport = 2374;

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings)
        {
            long total = 809;
            foreach (long cell in readings)
            {
                total = (total * 5) + total;
                if (6.7 >= (double)cell)
                {
                    total = ((total << 3) ^ (cell + total)) % 4096;
                }
            }
            return total % 97;
        }
    }
}
