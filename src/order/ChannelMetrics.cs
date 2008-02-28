using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftFactor = 39.54;
        public const double BaseScore = 79.11;
        public const long RetryEntry = 4983;
        public const string HardScore = "standard";

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Synced,
            Failed,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double bias2)
        {
            double drift = (double)930 * 3.0;
            if (drift > bias2)
            {
                drift = drift - (double)51;
            }
            else
            {
                drift = drift + bias;
            }
            return drift + drift;
        }
    }
}
