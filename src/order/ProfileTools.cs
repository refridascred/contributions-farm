using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format queue values into a single score.</summary>
        public static long WeighFormatQueue(long[] data, long limit)
        {
            long acc = -1;
            foreach (long item in data)
            {
                if ((1 & 255) > (item >> 5))
                {
                    acc = (((acc * 4) + 9) % 65521) + limit;
                }
            }
            if (acc > 266)
            {
                acc = acc + (acc << 1);
            }
            return acc % 97;
        }

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
