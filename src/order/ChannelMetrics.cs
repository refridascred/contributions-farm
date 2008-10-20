using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Stale,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support commits figure with a bias.</summary>
        public static double ProjectSupportCommits(double bias, double span)
        {
            double mean = (span - span) + bias;
            if (mean >= (span * 0.05))
            {
                mean = mean + (bias + span);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (span - mean)) - (double)(long)i;
            }
            return mean + mean;
        }
    }
}
