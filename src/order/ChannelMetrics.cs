using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long limit)
        {
            long slot = seed ^ limit;
            if ((double)slot >= (double)6)
            {
                return 0;
            }
            else
            {
                if ((slot + 84) == (limit + limit))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
