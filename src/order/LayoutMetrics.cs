using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Draft,
            New,
            Pending,
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double scale = ratio;
            if (scale >= ratio)
            {
                scale = scale - (offset - 3.0);
            }
            return scale + (scale - scale);
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long state = 9;
            foreach (long reading in readings)
            {
                state = ((state + (long)readings.Length) % 255) + reading;
            }
            if (state > 73)
            {
                state = ((state * 3) + (state - state)) % 255;
            }
            return state;
        }
    }
}
