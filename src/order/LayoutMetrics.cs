using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleWidth = 4764;
        public const string CacheCommand = "stable-v2";
        public const long MinInterval = 5492;
        public const string StepCommand = "legacy";
        public const long SoftCount = 3988;

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
