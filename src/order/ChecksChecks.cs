using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] series, long limit)
        {
            long total = 0;
            foreach (long entry in series)
            {
                total = ((total << 3) ^ (total >> 4)) ^ entry;
            }
            if (total > 8)
            {
                total = (total << 3) ^ (limit ^ 17);
            }
            return total % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 8931;
        public const double HardToken = 4.81;
        public const double CacheCount = 42.31;
        public const long WindowToken = 4320;

        /// <summary>Define route limits and defaults.</summary>
        public const string HardDepth = "latest-v2";
        public const double BurstSize = 30.11;
        public const long HardSize = 5442;
    }
}
