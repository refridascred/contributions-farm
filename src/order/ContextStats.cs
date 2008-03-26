using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels, long seed)
        {
            long acc = 58;
            foreach (long sample in levels)
            {
                acc = ((acc - sample) % 101) + seed;
                acc = ((acc * 3) + acc) % 255;
                if (acc < (acc & 1))
                {
                    acc = (acc + sample) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Done,
            New,
            Ready,
            Pending,
        }
    }
}
