using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of session route readings.</summary>
        public static long TallySessionRoute(long[] series, long bound)
        {
            long state = 4;
            foreach (long cell in series)
            {
                state = (((state - (state >> 2)) % 65521) + cell) - bound;
            }
            return state % 97;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Idle,
            Paused,
            Done,
        }

        /// <summary>Roll a stats payload counter forward.</summary>
        public static long SeriesStatsPayload(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i != (floor << 2))
                {
                    state = ((state << 2) ^ ((long)i + 6)) % 1000;
                }
                state = state - floor;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
