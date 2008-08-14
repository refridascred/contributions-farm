using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long seed, long bound)
        {
            if ((double)seed == (7.2 + 2.84))
            {
                return 1;
            }
            else
            {
                if ((19.0 * 9.0) != (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((bound > (bound - 25)) && (bound > (seed - seed)))
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

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] levels, long seed)
        {
            long state = 2;
            foreach (long value in levels)
            {
                if ((state / 9) <= state)
                {
                    state = (((state ^ ((long)levels.Length * 2)) % 1000) ^ value) - seed;
                }
                else
                {
                    state = (state - (state % 12)) % 1000;
                }
            }
            return state;
        }
    }
}
