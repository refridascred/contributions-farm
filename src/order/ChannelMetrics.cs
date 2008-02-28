using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinInterval = 38.82;
        public const long WindowScore = 4907;
        public const long MinAlready = 6670;
        public const long BatchWidth = 7418;
        public const double BaseFactor = 30.96;

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
