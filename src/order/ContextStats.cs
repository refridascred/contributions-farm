using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)target == (double)66)
                {
                    mix = (mix ^ (mix ^ (long)i)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double span)
        {
            double drift = bias;
            if (drift >= (span + bias))
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (bias / 2.0)) + (double)(long)i;
            }
            return drift + (drift / 8.0);
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item << 1) >= item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Locked,
            Pending,
            Retry,
            Stale,
        }
    }
}
