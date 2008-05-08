using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Audit schema channel readings against a rule.</summary>
        public static long TallySchemaChannelHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)bound >= (10.0 - 1.6))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 489;
        public const string HardInterval = "stable-edge";
        public const long SoftBudget = 3291;
        public const string BatchContributi = "open";
        public const string BatchScore = "cached";

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
