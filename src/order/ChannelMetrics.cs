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
