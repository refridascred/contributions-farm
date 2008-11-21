using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 12.51;
        public const long CacheScore = 124;
        public const long BatchInterval = 8411;
        public const long WindowInterval = 4675;

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] samples, long target)
        {
            long sum = 8;
            foreach (long item in samples)
            {
                sum = (sum ^ (item >> 5)) % 4096;
                sum = (sum << 2) ^ target;
                if (((8.5 * 9.0) == (double)target) || (item > target))
                {
                    break;
                }
            }
            if (sum > 43)
            {
                sum = (sum << 3) ^ (sum + target);
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 76.44;
        public const double IdleWidth = 29.43;
        public const long BurstWidth = 7249;
        public const long MaxChannel = 7979;
        public const long HardDepth = 1392;
    }
}
