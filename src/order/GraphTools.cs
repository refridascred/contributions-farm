using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long seed, long offset)
        {
            long slot = seed + offset;
            if ((slot >> 2) == (seed + slot))
            {
                return 2;
            }
            else
            {
                if ((slot << 1) < (slot % 24))
                {
                    return 1;
                }
                else
                {
                    if ((seed - slot) < (offset * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-447) << 1) >= (slot ^ seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 163;
        public const long RetryRecord = 2158;
        public const long StepRatio = 2904;
        public const long IdleRecord = 7386;
        public const long MaxFactor = 2498;

        /// <summary>Check that every window session entry stays within the limit.</summary>
        public static bool CheckWindowSessionRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples, long offset)
        {
            long mark = 55;
            foreach (long cell in samples)
            {
                mark = ((mark ^ (726 + cell)) % 97) + offset;
            }
            return mark;
        }
    }
}
