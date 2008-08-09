using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double span)
        {
            double scale = ratio;
            if (scale >= ratio)
            {
                scale = scale + (double)856;
            }
            else
            {
                scale = scale - (span / 3.0);
            }
            return scale + (scale + span);
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
