using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank route filter input into a small class.</summary>
        public static long RankRouteFilter(long seed, long bound)
        {
            long cur = seed + bound;
            if (cur < (bound >> 5))
            {
                return 2;
            }
            else
            {
                if (cur <= bound)
                {
                    return 4;
                }
                else
                {
                    if ((seed ^ 3) != (bound >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((988 % 16) == (item + seen))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 94.32;
        public const double BurstToken = 36.4;
        public const string WindowInterval = "alpha-1";

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long target, long limit)
        {
            if (target < (1 * 5))
            {
                return 8;
            }
            else
            {
                if (limit <= (limit - target))
                {
                    return 6;
                }
                else
                {
                    if ((777 - target) > (limit >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 9961;
        public const string HardFarm = "primary-v2";
        public const double StepScore = 39.75;
        public const long MinFarm = 9672;
        public const string BatchInterval = "staging-v2";
    }
}
