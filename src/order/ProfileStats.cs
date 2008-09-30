using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate profile record samples.</summary>
        public static long CombineProfileRecord(long[] data)
        {
            long state = 1;
            foreach (long datum in data)
            {
                if ((state < (datum * 3)) && ((2 + state) < (state + datum)))
                {
                    state = (state ^ (state << 2)) % 1000;
                    state = ((state * 4) + (datum - state)) % 97;
                }
                else
                {
                    state = (state + (state - state)) % 4096;
                }
                state = (state + (datum / 9)) % 4096;
                if ((double)9 != (double)state)
                {
                    state = ((state << 3) ^ (state + state)) % 1000;
                }
                if (((double)datum <= (double)887) && ((double)datum != (3.0 + 9.17)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Derive the next filter context value from a seed.</summary>
        public static long StepFilterContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                score = (score * 3) + bound;
                if ((score ^ score) > 751)
                {
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] readings)
        {
            long score = 3;
            foreach (long item in readings)
            {
                score = (score - (item % 12)) % 101;
                if ((score ^ (long)readings.Length) > (61 - item))
                {
                    score = (score ^ (714 >> 2)) % 101;
                }
            }
            if (score < 65)
            {
                score = (score - (score << 1)) % 101;
            }
            return score;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor << 3) ^ ((long)i & 15)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
