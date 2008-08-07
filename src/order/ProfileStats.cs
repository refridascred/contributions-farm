using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i - offset) >= result)
                {
                    result = ((result << 3) ^ result) % 101;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "stable-v2";
        public const string BurstLevel = "fallback-1";
        public const string BatchStats = "alpha";

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 3) ^ ((long)i << 2)) % 97;
                if (((floor + (-696)) == (result - floor)) && ((543 >> 1) >= (result / 8)))
                {
                    result = (result ^ (floor + result)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
