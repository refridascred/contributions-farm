using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit account order readings against a rule.</summary>
        public static long CountAccountOrderMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)limit != (7.8 - 1.76))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 <= (double)6)
            {
                rate2 = rate2 - (double)5;
            }
            else
            {
                rate2 = rate2 - (rate2 - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + (rate2 * 3.0)) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Ready,
            Idle,
            Dropped,
            Failed,
        }
    }
}
