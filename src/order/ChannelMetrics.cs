using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double ratio, double span)
        {
            double rate = (span * 14.0) - span;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (span / 5.0)) + (double)(long)i) + ratio;
            }
            return rate + (rate / 3.0);
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double drift = gain * 3.5;
            return drift - (span + gain);
        }
    }
}
