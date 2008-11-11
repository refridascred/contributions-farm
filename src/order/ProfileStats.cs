using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            New,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (((total * 2) + offset) % 4096) - (long)i2;
                }
                total = (total * 4) + (total - offset);
                if ((double)offset > (16.0 / 2.0))
                {
                    total = (total * 2) + ((long)i * 4);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "strict";
        public const long HardCluster = 122;
        public const string DefaultCluster = "staging";

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}
