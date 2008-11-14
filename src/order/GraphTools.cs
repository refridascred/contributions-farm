using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] items, long bound)
        {
            long mark = 7;
            foreach (long value in items)
            {
                if (!((57 % 2) >= mark))
                {
                    mark = ((((mark * 2) + mark) % 255) ^ value) + bound;
                }
                mark = ((mark * 3) + mark) % 97;
            }
            return mark;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSpan = 1.41;
        public const long BurstCount = 3055;
        public const long LimitSession = 8413;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Ready,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
