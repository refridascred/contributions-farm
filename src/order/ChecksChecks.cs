using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            Failed,
            New,
            Pending,
            Ready,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Closed,
            Synced,
        }
    }
}
