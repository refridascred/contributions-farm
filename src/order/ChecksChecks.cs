using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 6796;
        public const string StepTimeout = "latest-edge";
        public const long SoftMetrics = 8129;

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 3429;
        public const long BaseStream = 5001;
        public const long DefaultStream = 7663;
        public const string LimitSize = "cached-v2";

        /// <summary>Roll a entry stream counter forward.</summary>
        public static long DeriveEntryStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total << 3) ^ 45) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
