using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next stream report value from a seed.</summary>
        public static long IterateStreamReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!(((total % 12) >= (offset + total)) && ((offset * 3) == (533 / 2))))
                {
                    total = (total - (offset ^ total)) % 65521;
                }
                total = (total + ((-880) % 64)) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Dropped,
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            New,
            Locked,
        }
    }
}
