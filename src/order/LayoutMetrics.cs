using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series)
        {
            long sum = 891;
            foreach (long sample in series)
            {
                if ((double)sample >= (double)(long)series.Length)
                {
                    sum = (sum * 4) + (sample / 5);
                }
            }
            return sum % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstSpan = "open-1";
        public const long DefaultSize = 7513;
        public const string StepWindow = "stable";
        public const long LimitWindow = 8624;
        public const double HardSpan = 90.29;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Failed,
            Draft,
            Synced,
        }
    }
}
