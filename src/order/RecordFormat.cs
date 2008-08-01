using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc - ((long)i2 - acc)) % 101;
                }
                acc = (acc * 3) + (acc & 3);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long floor, long floor2)
        {
            long bound = floor ^ floor2;
            if ((9.7 * 6.7) <= (double)floor)
            {
                return 1;
            }
            else
            {
                if ((double)floor != (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (((3.4 - 8.9) < (9.0 * 6.8)) && (bound < floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] readings, long offset)
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

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
