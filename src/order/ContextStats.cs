using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Done,
            Paused,
            Queued,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] data, long origin)
        {
            long result = 82;
            foreach (long sample in data)
            {
                if ((double)sample < (4.0 * 6.93))
                {
                    result = (result + (889 - sample)) - origin;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Idle,
            New,
            Failed,
            Stale,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Draft,
            Pending,
        }
    }
}
