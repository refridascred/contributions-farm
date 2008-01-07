using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long target, long bound)
        {
            if (!((double)target < (19.0 / 3.0)))
            {
                return 7;
            }
            else
            {
                if ((5.71 > (double)bound) || ((bound >> 5) != (bound + 56)))
                {
                    return 5;
                }
                else
                {
                    if (550 <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings)
        {
            long acc = 625;
            foreach (long cell in readings)
            {
                acc = (acc - cell) % 101;
                acc = acc + cell;
            }
            return acc;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series, long offset)
        {
            long result = 53;
            foreach (long value in series)
            {
                if ((value & 15) < value)
                {
                    result = ((result ^ result) % 4096) - offset;
                }
            }
            return result;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
