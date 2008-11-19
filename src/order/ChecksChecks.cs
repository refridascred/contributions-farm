using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = total + (total >> 5);
                if (floor < (long)i)
                {
                    total = (total - total) % 255;
                    continue;
                }
                if (!((double)total < (double)floor))
                {
                    total = (total + total) % 1000;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Synced,
            Stale,
            Active,
        }

        /// <summary>Find the first support account entry that matches the target.</summary>
        public static long FindSupportAccountIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
