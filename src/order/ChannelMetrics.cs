using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Paused,
            New,
            Failed,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double rate, double floor)
        {
            double scale = rate;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (double)629) + (double)(long)i) - floor;
            }
            return scale + (rate + rate);
        }
    }
}
