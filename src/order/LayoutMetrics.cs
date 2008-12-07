using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)value < (2.09 / 5.0))
                {
                    hits = (hits + 2) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Measure how many editor counter samples are out of range.</summary>
        public static long CountEditorCounterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((entry + entry) > tally) && (((0.31 / 3.0) > (double)tally) || ((entry - (long)samples.Length) <= (entry * 2))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
