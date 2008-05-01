using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next cache payload value from a seed.</summary>
        public static long RollCachePayload(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                state = (state ^ (state + target)) % 101;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((4.0 / 5.0) >= (double)hits))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((7.65 + 12.0) < (double)matches) || !((double)matches <= (double)value))
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double span)
        {
            double ratio = span;
            return (ratio + (double)62) + bias;
        }
    }
}
