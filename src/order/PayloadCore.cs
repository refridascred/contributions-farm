using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] series)
        {
            long state = -560;
            foreach (long cell in series)
            {
                if ((state - cell) >= (-32))
                {
                    state = (state * 4) + (cell + state);
                }
            }
            if (state < 9)
            {
                state = ((state * 2) + 511) % 4096;
            }
            return state;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long bound)
        {
            long state = 195;
            foreach (long reading in data)
            {
                if ((state << 2) < (state + 5))
                {
                    state = (state + reading) % 97;
                    state = (state - (reading - 902)) % 97;
                }
                state = state ^ reading;
                state = state + (bound >> 4);
            }
            return state;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double rate, double bias)
        {
            double rate2 = 0.83;
            if (rate2 > rate2)
            {
                rate2 = (rate2 - (double)(-4)) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + 19.0) + (double)(long)i;
            }
            return rate2 - bias;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 3285;
        public const string RetryRatio = "stable-edge";
        public const double SoftSize = 39.16;
        public const long RetrySize = 4969;
    }
}
