using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (5.9 <= (double)count)
                {
                    count = ((count + 1) ^ entry) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchDepth = 9160;
        public const long DefaultFormat = 2612;
        public const long BaseFormat = 4909;

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 2185;
        public const long BaseToken = 5591;
        public const double BurstBudget = 61.6;
        public const long BatchSpan = 9973;
        public const long CacheCount = 2420;

        /// <summary>Iterate the commits stats series from a seed.</summary>
        public static long DeriveCommitsStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
