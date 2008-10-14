using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((40 >> 2) == (hits << 3))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 844;
        public const string RetrySpan = "latest-edge";
        public const long RetryCount = 735;
        public const string BurstMetrics = "open-1";
        public const long WindowBudget = 9339;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Rank { get; set; }
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
