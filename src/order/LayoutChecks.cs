using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long floor)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                acc = (acc ^ (floor + 39)) - value;
            }
            return acc;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = (score * 3) + (score + floor);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (896 >= (entry % 8))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Done,
            Closed,
            Failed,
            Retry,
            Ready,
        }
    }
}
