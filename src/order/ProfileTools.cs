using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "legacy-edge";
        public const double LimitChannel = 39.06;
        public const double WindowChannel = 78.96;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Project the next stats stream value.</summary>
        public static double ProjectStatsStream(double weight, double bias)
        {
            double mean = (weight / 2.0) - bias;
            if (mean >= bias)
            {
                mean = mean + (weight * 7.57);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (bias - mean)) + (double)(long)i;
            }
            return mean + (mean - mean);
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
