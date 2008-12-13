using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a tools filter reading by value.</summary>
        public static long FindToolsFilterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double bias)
        {
            double drift = ratio;
            if (drift >= (ratio * 5.64))
            {
                drift = drift + (ratio + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift - (bias / 6.0);
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double rate, double bias)
        {
            double drift = bias;
            if (drift >= 2.4)
            {
                drift = (drift - drift) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)3) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
