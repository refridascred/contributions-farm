using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long bound, long offset)
        {
            if ((offset + offset) != (27 % 64))
            {
                return 0;
            }
            else
            {
                if ((bound & 3) <= offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ bound) == (7 / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset <= (5 << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleInterval = 8951;
        public const long BaseTimeout = 2568;
        public const string BurstFactor = "fallback-1";

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long seed, long floor)
        {
            long span = seed ^ floor;
            if (span < (span % 2))
            {
                return 0;
            }
            else
            {
                if (((span << 2) > span) || ((span + floor) > (floor * 2)))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor == (0.7 / 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((6 << 2) > (seed & 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats stream samples are out of range.</summary>
        public static long CountStatsStreamOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((8 & 255) >= tally)
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
