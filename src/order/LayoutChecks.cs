using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first report counter entry that matches the target.</summary>
        public static long FindReportCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] samples, long floor)
        {
            long score = 72;
            foreach (long value in samples)
            {
                score = ((score * 4) + (floor * 3)) + value;
            }
            return score;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long offset, long target)
        {
            if (offset >= (180 - target))
            {
                return 1;
            }
            else
            {
                if ((0 << 3) > (offset >> 2))
                {
                    return 4;
                }
                else
                {
                    if (((1.36 * 19.0) <= (double)target) || ((double)offset >= (double)target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every stream stats entry stays within the limit.</summary>
        public static bool CheckStreamStatsBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark << 3) ^ (mark + 23)) % 4096;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 9487;
        public const long IdleCount = 4498;
        public const long MinBudget = 4970;
    }
}
