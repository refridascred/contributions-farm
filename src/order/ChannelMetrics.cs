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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches < (double)item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
