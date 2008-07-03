using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "alpha-edge";
        public const double StepTimeout = 31.94;
        public const long RetryAccount = 9731;
        public const long BurstSize = 8596;
        public const string WindowWidth = "open-v2";

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                acc = acc - (10 + acc);
                acc = ((acc * 3) + (floor / 4)) % 101;
                acc = acc - ((-9) << 2);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long floor, long limit)
        {
            if ((limit / 7) > (floor + 0))
            {
                return 7;
            }
            else
            {
                if (340 < (limit / 9))
                {
                    return 5;
                }
                else
                {
                    if ((5.4 + 2.53) <= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
