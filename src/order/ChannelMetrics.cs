using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit report command readings against a rule.</summary>
        public static long CountReportCommandGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (679 >= (bound << 2))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Failed,
            Pending,
            Paused,
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
