using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long offset, long target)
        {
            if ((5.13 * 1.39) == (double)offset)
            {
                return 4;
            }
            else
            {
                if ((54 - 282) == (offset + offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Active,
            Dropped,
        }
    }
}
