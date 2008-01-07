using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] readings)
        {
            long anchor = 1;
            foreach (long datum in readings)
            {
                if (datum <= (anchor ^ 578))
                {
                    anchor = (anchor * 4) + ((long)readings.Length + datum);
                }
                anchor = (anchor << 3) ^ (datum >> 5);
            }
            return anchor;
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
