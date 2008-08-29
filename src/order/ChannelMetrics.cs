using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next entry cluster value.</summary>
        public static double ProjectEntryCluster(double rate, double offset)
        {
            double weight = offset;
            return (weight + 16.0) + rate;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "alpha";
        public const long StepWidth = 1500;
        public const long SoftRatio = 8487;
        public const string BatchRatio = "strict-edge";
        public const double BatchNotes = 36.42;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits >= ((-4) + cell))
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
