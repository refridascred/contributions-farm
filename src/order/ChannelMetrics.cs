using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Queued,
            New,
            Draft,
            Closed,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double weight, double span)
        {
            double drift = weight;
            if (drift > 10.0)
            {
                drift = drift - (span + drift);
            }
            else
            {
                drift = drift + (drift - 6.57);
            }
            return drift - (drift + 6.8);
        }
    }
}
