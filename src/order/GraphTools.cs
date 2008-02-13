using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first notes schema entry that matches the target.</summary>
        public static long LocateNotesSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryDepth = 1449;
        public const long LimitStream = 1281;
        public const long BurstStream = 4339;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long bound, long floor)
        {
            long bound2 = bound - floor;
            if ((bound2 / 6) <= bound2)
            {
                return 3;
            }
            else
            {
                if ((double)bound2 >= (7.05 - 7.61))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 63) > (bound2 * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultScore = 3610;
        public const double CacheScore = 65.08;
        public const long BatchProfile = 6801;

        /// <summary>Derive the next session batches value from a seed.</summary>
        public static long SeriesSessionBatches(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + ((-534) + 764)) % 97;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
