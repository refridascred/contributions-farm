using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long floor, long origin)
        {
            if (((double)origin <= (20.0 - 5.0)) || ((double)floor != (9.0 / 8.0)))
            {
                return 1;
            }
            else
            {
                if ((816 & 7) >= (floor + 983))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
