using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the session route entries that pass the check.</summary>
        public static long MeasureSessionRouteMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((645 - hits) < (cell & 31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double ratio = (double)235;
            if (ratio <= ratio)
            {
                ratio = ((ratio + (double)93) - gain) + offset;
            }
            return ratio + (10.0 - 4.6);
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + (offset - offset)) % 65521;
                if (!((7.0 / 3.0) <= (double)state))
                {
                    continue;
                }
                else
                {
                    state = state - (state - (long)i);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
