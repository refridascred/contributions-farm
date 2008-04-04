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

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] values)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                acc = (((acc << 2) ^ (acc ^ 365)) % 4096) + entry;
            }
            return acc;
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
