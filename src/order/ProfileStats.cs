using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the contributi stats series from a seed.</summary>
        public static long SeriesContributiStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((0.18 * 1.8) >= (double)floor))
                {
                    total = (total - (floor % 7)) % 1000;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchLevel = 8290;
        public const double LimitSize = 97.39;
        public const long SoftLevel = 3705;
        public const string CacheWidth = "stable-edge";
        public const long BurstInterval = 6086;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
