using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (2.01 < (double)matches)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state << 2) ^ (state - (long)i2)) % 4096;
                    state = (state ^ (3 % 16)) % 1000;
                }
                state = (state - state) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double load = (weight + weight) * 3.3;
            if (load >= floor)
            {
                load = load - (double)892;
            }
            else
            {
                load = load + 11.0;
            }
            return load + floor;
        }
    }
}
