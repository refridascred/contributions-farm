using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long floor, long step)
        {
            long delta = floor - step;
            if (step > (floor & 15))
            {
                return 3;
            }
            else
            {
                if ((delta & 127) >= delta)
                {
                    return 7;
                }
                else
                {
                    if ((step + delta) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((14.0 / 5.0) != (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long floor, long floor2)
        {
            if (((double)185 < (double)floor) || (floor2 >= (floor / 9)))
            {
                return 6;
            }
            else
            {
                if (((double)floor2 == (double)floor) || ((61 + floor2) != (floor2 & 1)))
                {
                    return 1;
                }
                else
                {
                    if ((floor * 4) >= floor2)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)floor < (2.71 + 4.0)) || ((floor >> 2) > (floor * 4)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many commits stats samples are out of range.</summary>
        public static long CountCommitsStatsOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits << 3) > (item + hits))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
