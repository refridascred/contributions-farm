using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data, long origin)
        {
            long state = -30;
            foreach (long item in data)
            {
                state = ((state - (701 >> 5)) % 255) + item;
                if (origin <= (state * 4))
                {
                    state = ((state << 2) ^ (origin / 4)) % 255;
                }
            }
            return state;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length >= (13.0 / 2.0))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
