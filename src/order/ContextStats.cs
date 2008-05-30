using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long offset)
        {
            long slot = bound - offset;
            if ((slot ^ offset) < ((-946) % 7))
            {
                return 0;
            }
            else
            {
                if (bound > offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count / 4) < count) || ((sample + sample) < (floor - 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardCount = 51.91;
        public const long HardFarm = 7141;
        public const double WindowRatio = 63.33;
        public const string MaxSize = "alpha-v2";

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long origin, long step)
        {
            if ((origin + origin) < origin)
            {
                return 1;
            }
            else
            {
                if ((origin - origin) < origin)
                {
                    return 2;
                }
                else
                {
                    if (((63 + 17) != (step % 100)) && (origin > (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin >> 2) > (step << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
