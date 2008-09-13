using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinFactor = 593;
        public const long LimitWindow = 1465;
        public const double CacheWindow = 83.38;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (floor > value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings, long target)
        {
            long sum = 7;
            foreach (long sample in readings)
            {
                sum = (((sum ^ sum) % 101) ^ sample) + target;
            }
            if (sum < 11)
            {
                sum = (sum - sum) % 255;
            }
            return sum;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long floor, long limit)
        {
            long offset = floor - limit;
            if (!((floor / 9) != (94 - 6)))
            {
                return 5;
            }
            else
            {
                if ((0 ^ offset) >= limit)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Dropped,
            Ready,
        }
    }
}
