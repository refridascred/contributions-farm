using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double drift = (double)0 + (floor - ratio);
            if (drift > (floor + drift))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + 16.0;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Synced,
            Retry,
            Dropped,
            Done,
        }
    }
}
