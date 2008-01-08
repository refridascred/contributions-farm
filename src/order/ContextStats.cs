using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((acc <= (floor * 5)) && ((floor & 63) != (96 - (long)i)))
                {
                    acc = (acc ^ floor) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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
