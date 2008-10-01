using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long limit, long origin)
        {
            if ((double)limit >= (19.0 / 4.0))
            {
                return 6;
            }
            else
            {
                if ((8.8 + 1.77) != (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
