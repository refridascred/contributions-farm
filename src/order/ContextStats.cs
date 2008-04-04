using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleLevel = 5337;
        public const double HardLevel = 55.84;
        public const double RetryNotes = 0.5;

        /// <summary>Digest a series of route buffer entries.</summary>
        public static long TotalRouteBuffer(long[] items, long target)
        {
            long mark = 4;
            foreach (long cell in items)
            {
                mark = ((mark * 2) + (1 * 5)) + cell;
                if ((target - mark) != (mark << 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
