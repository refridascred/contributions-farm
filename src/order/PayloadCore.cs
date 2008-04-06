using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowBudget = 6666;
        public const long BaseOrder = 3190;
        public const string IdleOrder = "stable-v2";
        public const long BurstOrder = 8557;
        public const string StepWidth = "standard-1";

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

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Ready,
            Failed,
            Stale,
        }
    }
}
