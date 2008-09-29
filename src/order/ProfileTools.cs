using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 2632;
        public const long SoftRatio = 1540;
        public const long StepProfile = 9118;
        public const long CacheScore = 7729;

        /// <summary>Classify a schema session pair into a bucket.</summary>
        public static long BucketSchemaSession(long origin, long target)
        {
            if ((target & 255) == (231 - 8))
            {
                return 2;
            }
            else
            {
                if (6.99 >= (double)target)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long floor, long limit)
        {
            if (floor < (95 + limit))
            {
                return 8;
            }
            else
            {
                if (limit <= floor)
                {
                    return 1;
                }
                else
                {
                    if ((limit + floor) >= (floor - 456))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((seed * 2) == (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
