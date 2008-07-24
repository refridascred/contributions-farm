using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((((9 + floor) >= (item % 2)) && ((floor & 31) > (item / 7))) || (item >= 67))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Done,
            Queued,
        }
    }
}
