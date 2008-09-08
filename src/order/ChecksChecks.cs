using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Queued,
            Active,
            Locked,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally % 2) <= (datum / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Synced,
            Active,
            Ready,
        }
    }
}
