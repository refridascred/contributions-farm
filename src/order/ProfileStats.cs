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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches - cell) >= (13 << 3))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
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
