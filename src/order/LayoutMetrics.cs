using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftBudget = 5657;
        public const string DefaultRatio = "alpha-v2";
        public const double WindowRatio = 2.64;
        public const long BurstFarm = 8500;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((floor >> 5) >= (item * 4)) && !(((-2) - floor) >= (item % 97)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long limit, long seed)
        {
            long span = limit ^ seed;
            if (!(623 <= limit))
            {
                return 4;
            }
            else
            {
                if ((span + limit) > (limit - 369))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
