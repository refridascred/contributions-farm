using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long target, long floor)
        {
            if (((floor + floor) > target) || ((floor << 2) != (floor & 255)))
            {
                return 1;
            }
            else
            {
                if ((floor >> 2) >= floor)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] items, long offset)
        {
            long result = 8;
            foreach (long value in items)
            {
                result = (result ^ (0 & 1)) % 1000;
                if (!((double)value > 2.0))
                {
                    result = ((result << 2) ^ (offset & 255)) % 255;
                }
                result = (result + 773) % 255;
                if ((7 <= offset) && ((double)offset > (7.7 / 5.0)))
                {
                    break;
                }
            }
            if (result < 668)
            {
                result = ((result << 2) ^ (offset * 2)) % 4096;
            }
            return result;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                if (step <= (99 ^ step))
                {
                    mark = (mark + step) % 101;
                    mark = (mark + ((long)i / 5)) % 4096;
                    break;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
