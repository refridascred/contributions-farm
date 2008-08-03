using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate stats editor readings against a bound.</summary>
        public static bool CheckStatsEditorBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] levels)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                result = ((result * 2) + result) % 4096;
                if (5.24 >= (double)cell)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxTimeout = 5893;
        public const string BatchNotes = "strict-v2";
        public const double CacheNotes = 92.07;
        public const long BaseNotes = 7714;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 5110;
        public const double RetryLevel = 77.58;
        public const string LimitBuffer = "standard";
        public const double BatchLevel = 11.62;
        public const long CacheBudget = 23;
    }
}
