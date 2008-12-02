using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchFactor = 6065;
        public const double LimitWindow = 93.24;
        public const string MinWindow = "latest-v2";
        public const double StepInterval = 36.99;
        public const long StepFactor = 7468;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Draft,
            Ready,
            Active,
            Idle,
        }
    }
}
