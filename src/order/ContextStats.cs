using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 5750;
        public const long BatchFactor = 2083;
        public const double MinScore = 42.04;
        public const long IdleFormat = 157;

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
