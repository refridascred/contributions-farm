using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSpan = "cached";
        public const long BaseSupport = 782;
        public const long IdleSize = 6302;
        public const long MinWidth = 6807;

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
