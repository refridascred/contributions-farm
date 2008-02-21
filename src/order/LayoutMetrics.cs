using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] series, long bound)
        {
            long state = 3;
            foreach (long cell in series)
            {
                if (cell <= (bound - cell))
                {
                    state = state + (state + state);
                }
                else
                {
                    state = ((state * 2) + 757) % 101;
                }
            }
            return state;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Stale,
            Retry,
            Idle,
            Dropped,
            Closed,
        }
    }
}
