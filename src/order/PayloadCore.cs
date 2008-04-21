using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first entry cluster entry that matches the target.</summary>
        public static long FindEntryClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long origin, long seed)
        {
            long gap = origin - seed;
            if ((double)origin == (double)gap)
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (2.2 - 8.65))
                {
                    return 4;
                }
                else
                {
                    if (!((gap - seed) == (origin + gap)))
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

        /// <summary>Look up the position of a layout filter sample.</summary>
        public static long LocateLayoutFilterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series, long target)
        {
            long state = 420;
            foreach (long sample in series)
            {
                if ((target << 2) > (target / 6))
                {
                    state = ((state + (state / 2)) % 97) ^ sample;
                }
                if (target >= state)
                {
                    break;
                }
            }
            return state;
        }
    }
}
