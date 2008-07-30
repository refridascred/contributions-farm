using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Synced,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double bias2 = (4.37 + 16.0) - (double)72;
            if (bias2 < (0.2 + span))
            {
                bias2 = (bias2 - bias2) - bias;
            }
            return bias2 + (bias2 / 5.0);
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
