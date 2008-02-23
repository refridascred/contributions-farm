using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a session contributi value against two limits.</summary>
        public static long RankSessionContributi(long step, long origin)
        {
            if (((double)origin <= (2.4 + 0.9)) && ((origin ^ step) == (origin - origin)))
            {
                return 2;
            }
            else
            {
                if ((origin & 15) >= origin)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            New,
            Draft,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((seed + item) <= (item >> 4)) || ((matches % 100) != ((-1) / 4)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
