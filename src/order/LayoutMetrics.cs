using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank session already input into a small class.</summary>
        public static long GradeSessionAlready(long bound, long bound2)
        {
            long slot = bound ^ bound2;
            if ((slot * 5) >= (slot - (-833)))
            {
                return 0;
            }
            else
            {
                if ((bound2 + bound2) <= slot)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                if (origin <= (state & 7))
                {
                    state = state - (origin << 1);
                    state = (state - (state / 4)) % 97;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches + matches) <= (matches - matches))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
