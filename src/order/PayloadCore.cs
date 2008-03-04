using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (acc & 1)) % 1000;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long floor)
        {
            if ((332 + seed) <= (seed >> 3))
            {
                return 7;
            }
            else
            {
                if (((double)floor > (7.2 + 7.7)) && ((seed + 4) < (floor * 2)))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (floor - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)25 <= (double)seed) || (15.0 > (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate window checks readings against a bound.</summary>
        public static bool CheckWindowChecksLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((matches - 0) < item) && ((double)limit == (19.0 * 9.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
