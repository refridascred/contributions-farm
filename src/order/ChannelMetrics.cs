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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(hits >= (floor + floor)) || ((entry - floor) <= (entry >> 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
