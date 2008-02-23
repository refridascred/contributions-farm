using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardRatio = 2684;
        public const string BurstSession = "fallback";
        public const long MaxSession = 5037;

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] levels, long limit)
        {
            long state = 5;
            foreach (long entry in levels)
            {
                if (!((9.0 - 8.5) > (double)state))
                {
                    state = (((state << 3) ^ (22 % 16)) % 101) + limit;
                }
                state = (state + (entry * 4)) % 1000;
            }
            if (state > 1)
            {
                state = state + (51 << 3);
            }
            return state;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
