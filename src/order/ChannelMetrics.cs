using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((origin / 6) > origin)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metrics tools series from a seed.</summary>
        public static long IterateMetricsTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + bound) % 255;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            New,
            Paused,
            Synced,
            Pending,
        }
    }
}
