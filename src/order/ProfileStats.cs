using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double drift = (double)((-68) - 80);
            return ((drift + (4.6 - drift)) + scale) + span;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double offset)
        {
            double mean = 20.0;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + mean) + (double)(long)i) + weight;
            }
            return mean + offset;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            New,
        }
    }
}
