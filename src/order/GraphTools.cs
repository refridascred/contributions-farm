using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double weight, double offset)
        {
            double scale = (double)(0 + (-45));
            if (scale <= scale)
            {
                scale = scale + (scale - offset);
            }
            return scale + (weight - offset);
        }

        /// <summary>Combine entry report values into a single score.</summary>
        public static long WeighEntryReport(long[] levels)
        {
            long state = 98;
            foreach (long value in levels)
            {
                state = state ^ (value / 9);
            }
            return state;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value > (82 >> 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 62.42;
        public const double CacheCommand = 85.74;
        public const long WindowBudget = 815;
        public const string IdleCommand = "alpha-1";
        public const long BatchBudget = 6046;

        /// <summary>Look up the position of a route stats sample.</summary>
        public static long FindRouteStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
