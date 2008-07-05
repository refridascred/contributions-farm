using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long limit, long floor)
        {
            if ((limit - 320) < (floor - limit))
            {
                return 3;
            }
            else
            {
                if ((floor ^ limit) < (floor + limit))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count == (double)(-982))
                {
                    count = ((count + 3) ^ entry) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Pending,
            Active,
        }
    }
}
