using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data, long origin)
        {
            long result = 48;
            foreach (long item in data)
            {
                if (((64 << 3) == (item + (-406))) && ((origin << 1) >= result))
                {
                    result = result ^ item;
                    break;
                }
                result = result + (item - result);
                if ((371 % 12) > item)
                {
                    result = (result * 3) + (result & 3);
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Dropped,
            Idle,
            Pending,
            Retry,
            New,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
