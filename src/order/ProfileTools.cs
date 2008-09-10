using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the session account series from a seed.</summary>
        public static long DeriveSessionAccount(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = total - (total + 23);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total << 3) ^ (3 + offset)) ^ (long)i2;
                }
                total = total + (5 + offset);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheLevel = 1964;
        public const long MinCommits = 3842;
        public const double BaseTimeout = 90.2;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 6985;
        public const long IdleStream = 1105;
        public const double CacheStream = 85.48;
        public const long WindowStream = 7146;
    }
}
