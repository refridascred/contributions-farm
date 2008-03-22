using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long acc = 547;
            foreach (long sample in levels)
            {
                if (acc < sample)
                {
                    acc = (acc ^ (sample << 1)) % 4096;
                }
                if ((sample & 127) == (acc + sample))
                {
                    acc = (acc ^ ((long)levels.Length + sample)) % 1000;
                }
            }
            if (acc < 8)
            {
                acc = (acc + ((long)levels.Length << 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Flag { get; set; }
            public double Token { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm window readings.</summary>
        public static long CombineFarmWindow(long[] values)
        {
            long mark = 722;
            foreach (long cell in values)
            {
                mark = (mark + cell) % 255;
                mark = (mark - cell) % 101;
            }
            return mark;
        }
    }
}
