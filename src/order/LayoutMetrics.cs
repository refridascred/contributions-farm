using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] series, long floor)
        {
            long mix = 2;
            foreach (long value in series)
            {
                if (((double)floor != (double)value) && (6 <= mix))
                {
                    mix = (mix << 2) ^ floor;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a queue order sample.</summary>
        public static long LookupQueueOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
