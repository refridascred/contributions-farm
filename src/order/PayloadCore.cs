using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            New,
            Idle,
            Queued,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((bound * 2) == (seen << 1)) && ((seen & 15) == (cell << 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
