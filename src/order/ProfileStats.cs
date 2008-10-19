using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 3913;
        public const long HardCluster = 8347;
        public const double RetryInterval = 75.68;
        public const long RetryFactor = 7979;
        public const long BurstBudget = 852;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9114;
        public const string BatchScore = "strict";
        public const long RetryCount = 1740;
        public const long StepLevel = 8593;
        public const long CacheSchema = 804;
    }
}
