using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long target, long limit)
        {
            long gap = target ^ limit;
            if ((target - limit) == (limit & 31))
            {
                return 8;
            }
            else
            {
                if ((gap - 4) <= (target + target))
                {
                    return 3;
                }
                else
                {
                    if (0.54 > (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Level { get; set; }
            public bool Token { get; set; }
        }
    }
}
