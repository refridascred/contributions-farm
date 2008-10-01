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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading - floor) <= (floor << 1))
                {
                    count = count + 2;
                }
            }
            return count;
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
