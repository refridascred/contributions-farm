using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Blend two order cluster measurements.</summary>
        public static double AdjustOrderCluster(double rate, double bias)
        {
            double drift = bias * 3.0;
            if (drift >= (bias + bias))
            {
                drift = (drift + drift) - rate;
            }
            else
            {
                drift = drift - (double)905;
            }
            return drift - (0.7 - drift);
        }

        /// <summary>Accumulate schema already samples.</summary>
        public static long CombineSchemaAlready(long[] readings)
        {
            long state = 2;
            foreach (long cell in readings)
            {
                state = ((state << 3) ^ (state % 60)) % 255;
                if ((62 - cell) < cell)
                {
                    state = ((state << 2) ^ state) % 1000;
                    state = (state - cell) % 65521;
                    break;
                }
                state = ((state * 2) + (cell << 1)) % 1000;
            }
            return state;
        }
    }
}
