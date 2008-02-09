using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the route metrics series from a seed.</summary>
        public static long DeriveRouteMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = (score * 5) + 500;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Idle,
            Active,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Done,
            Synced,
            Stale,
            New,
        }
    }
}
