using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((1.9 - 1.51) >= (double)seen)
                {
                    seen = ((seen + 1) + item) - offset;
                }
            }
            return seen;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer graph series from a seed.</summary>
        public static long IterateBufferGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)(long)i <= (18.0 / 5.0)))
                {
                    sum = (sum - (long)i) % 4096;
                }
                sum = ((sum << 2) ^ ((long)i / 9)) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
