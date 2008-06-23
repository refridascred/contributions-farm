using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = total + (origin + origin);
                if (!((total - total) <= (860 * 4)))
                {
                    total = (total ^ (total + (long)i)) % 97;
                    total = ((total * 2) + (origin << 2)) % 255;
                    break;
                }
                else
                {
                    total = (total << 2) ^ (total << 1);
                }
                total = total + 3;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 55.93;
        public const long MaxTimeout = 4433;
        public const long CacheStats = 9954;
        public const long MinStats = 4068;
        public const long HardStats = 3328;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 9660;
        public const long MinCount = 4806;
        public const string BurstWindow = "alpha-edge";
    }
}
