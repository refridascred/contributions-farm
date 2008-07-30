using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two contributi token measurements.</summary>
        public static double BlendContributiToken(double gain, double offset)
        {
            double weight = gain;
            if (weight <= 5.1)
            {
                weight = (weight + (double)539) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (weight - weight)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Idle,
            Synced,
        }
    }
}
