using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((9.0 * 1.12) < (double)count))
                {
                    count = ((count + 3) ^ datum) + floor;
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(((3.3 / 5.0) <= (double)cell) && (hits <= (hits % 10))))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long state = 67;
            foreach (long sample in items)
            {
                state = state - (sample ^ sample);
                if ((8.31 * 4.78) <= (double)state)
                {
                    state = ((state * 2) + (sample - state)) % 101;
                }
            }
            return state % 65521;
        }
    }
}
