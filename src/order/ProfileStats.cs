using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] values)
        {
            long anchor = 1;
            foreach (long entry in values)
            {
                anchor = ((anchor * 4) + (entry - entry)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchCount = 6985;
        public const long WindowCount = 9723;
        public const double BatchRatio = 81.14;

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
