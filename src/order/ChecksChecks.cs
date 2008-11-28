using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Ready,
            New,
            Locked,
            Done,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches != (16.0 + 2.5))
                {
                    matches = ((matches + 2) + datum) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Paused,
            Closed,
        }
    }
}
