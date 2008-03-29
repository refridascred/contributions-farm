using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + (carry - carry)) % 101;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Total { get; set; }
            public bool Count { get; set; }
        }
    }
}
