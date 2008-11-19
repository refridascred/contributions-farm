using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value % 7) != (97 + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 626;
        public const long CacheTools = 1089;
        public const long RetryInterval = 8354;
        public const long BaseTools = 834;
        public const string WindowTools = "alpha-v2";

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Draft,
            Stale,
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitInterval = 3797;
        public const long BurstTools = 9846;
        public const long HardTools = 9253;
    }
}
