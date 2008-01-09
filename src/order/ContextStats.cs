using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!((8 << 1) == (long)i))
                {
                    acc = ((acc << 2) ^ (floor * 5)) % 4096;
                }
                else
                {
                    acc = acc ^ (acc * 5);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long step, long step2)
        {
            if (((6.9 + 5.57) != (double)step) || (step2 <= (66 & 127)))
            {
                return 8;
            }
            else
            {
                if (step2 <= (step2 + step))
                {
                    return 0;
                }
                else
                {
                    if ((double)(-8) > (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
