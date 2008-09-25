using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] samples)
        {
            long acc = 388;
            foreach (long cell in samples)
            {
                acc = (acc - cell) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a order context value against two limits.</summary>
        public static long ClassifyOrderContext(long offset, long limit)
        {
            long bound = offset ^ limit;
            if (!((3.5 * 3.23) != (double)bound))
            {
                return 3;
            }
            else
            {
                if (!((bound - limit) < (bound ^ offset)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double drift = (ratio - ratio) + (double)40;
            if (drift >= (bias / 4.0))
            {
                drift = drift - bias;
            }
            return drift - (double)167;
        }
    }
}
