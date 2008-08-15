using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels)
        {
            long carry = 61;
            foreach (long entry in levels)
            {
                carry = (carry + (2 + 97)) ^ entry;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "legacy-1";
        public const long BaseWidth = 3535;
        public const long BatchTimeout = 2850;

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 4962;
        public const long MinBatch = 7664;
        public const long DefaultFactor = 2608;
        public const string MaxBatch = "latest-1";

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Failed,
            Pending,
            Active,
            Ready,
        }
    }
}
