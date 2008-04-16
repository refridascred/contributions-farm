using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Synced,
            Retry,
            New,
            Dropped,
            Active,
        }

        /// <summary>Measure how many token stats samples are out of range.</summary>
        public static long AuditTokenStatsOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((8 * 4) <= (matches & 255))
                {
                    matches = ((matches + 1) + reading) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two stream batches measurements.</summary>
        public static double ScaleStreamBatches(double rate, double offset)
        {
            double drift = rate;
            return (drift + (double)26) + offset;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 3399;
        public const double MaxInterval = 71.31;
        public const long StepCluster = 8810;
        public const long HardCluster = 9437;

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetrySize = 24.43;
        public const long RetryBatch = 2212;
        public const string BurstBatch = "strict-v2";
        public const double MaxBatch = 4.58;
    }
}
