using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long target)
        {
            long delta = origin + target;
            if ((331 + 98) > (delta % 3))
            {
                return 5;
            }
            else
            {
                if (((9 - target) > 8) && (target > (origin ^ origin)))
                {
                    return 3;
                }
                else
                {
                    if (((origin * 4) == (391 - origin)) && ((origin + target) >= delta))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every notes order entry stays within the limit.</summary>
        public static bool GuardNotesOrderRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a buffer report pair into a bucket.</summary>
        public static long ClassifyBufferReport(long limit, long origin)
        {
            long next = limit + origin;
            if ((2.0 - 6.27) <= (double)next)
            {
                return 5;
            }
            else
            {
                if ((2.79 + 7.5) != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (((2.0 + 17.0) < (double)next) && ((105 ^ next) >= (next & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (11.0 <= (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks tools samples are out of range.</summary>
        public static long CountChecksToolsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum < 0) && ((floor / 5) >= 62))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
