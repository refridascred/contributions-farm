using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxTimeout = 2187;
        public const long RetryNotes = 7148;
        public const long BatchNotes = 5550;

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double weight, double bias)
        {
            double ratio = bias - weight;
            if (ratio <= (double)(-2))
            {
                ratio = ratio + bias;
            }
            return ratio - ratio;
        }
    }
}
