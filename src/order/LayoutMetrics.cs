using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data, long bound)
        {
            long total = 395;
            foreach (long item in data)
            {
                if (!((9.0 / 8.0) >= (double)item))
                {
                    total = (total ^ (total + 3)) % 65521;
                }
                if ((766 - item) <= (bound >> 5))
                {
                    total = (total ^ total) % 1000;
                }
                else
                {
                    total = (total - bound) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((137 + state) <= state) && (state > (state * 5)))
                {
                    state = (state + (state / 3)) % 101;
                }
                else
                {
                    state = (state - seed) % 255;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long step)
        {
            long result = 1;
            foreach (long cell in levels)
            {
                result = ((result << 2) ^ (cell >> 5)) % 255;
                result = result - (cell + step);
            }
            return result % 65521;
        }
    }
}
