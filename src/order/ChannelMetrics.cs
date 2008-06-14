using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Active,
            Synced,
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double bias, double floor)
        {
            double drift = (double)((-87) & 7);
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double scale, double floor)
        {
            double rate = floor * 4.9;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - (floor / 6.0)) + (double)(long)i) - scale;
            }
            return rate + rate;
        }
    }
}
