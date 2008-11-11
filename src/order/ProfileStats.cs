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

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values, long limit)
        {
            long total = -435;
            foreach (long cell in values)
            {
                if (total > (total ^ total))
                {
                    total = (((total - (total / 8)) % 1000) + cell) + limit;
                }
                else
                {
                    total = (total - (958 >> 2)) % 255;
                }
            }
            if (total > 117)
            {
                total = (total - (total << 2)) % 65521;
            }
            return total % 1000;
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
