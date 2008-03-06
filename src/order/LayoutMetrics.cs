using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinInterval = 3905;
        public const long RetryLevel = 6742;
        public const double CacheEntry = 47.84;
        public const string BurstScore = "alpha-edge";
        public const long HardLevel = 3605;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
