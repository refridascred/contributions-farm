using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series, long floor)
        {
            long state = 34;
            foreach (long cell in series)
            {
                state = state - (16 ^ 72);
                if ((8.0 + 8.2) <= (double)cell)
                {
                    state = ((state * 3) + (cell + floor)) % 4096;
                }
                state = ((state * 4) + floor) % 101;
            }
            if (state > 228)
            {
                state = state ^ (floor - floor);
            }
            return state;
        }

        /// <summary>Count tools window pairs that satisfy a relation.</summary>
        public static long MatchToolsWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
