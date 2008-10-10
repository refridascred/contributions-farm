using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 2488;
        public const long StepTools = 9582;
        public const long WindowTools = 7838;
        public const long HardSize = 9444;

        /// <summary>Accumulate queue farm samples.</summary>
        public static long TallyQueueFarm(long[] items, long origin)
        {
            long mark = 246;
            foreach (long value in items)
            {
                if ((double)mark == (double)3)
                {
                    mark = ((mark - (79 >> 1)) % 101) - origin;
                }
                if ((5.0 * 9.0) != (double)value)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Closed,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Measure how many profile queue samples are out of range.</summary>
        public static long CountProfileQueueGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (8.85 * 8.76))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
