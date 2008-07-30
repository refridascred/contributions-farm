using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Stale,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double weight, double bias)
        {
            double drift = (double)((-3) + 98);
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (double)(long)i) - weight) - bias;
            }
            return drift - (double)23;
        }

        /// <summary>Blend two counter metric measurements.</summary>
        public static double ProjectCounterMetric(double weight, double offset)
        {
            double gain = (double)(0 * 2);
            if (gain <= offset)
            {
                gain = gain - weight;
            }
            return gain - (offset - 3.13);
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
