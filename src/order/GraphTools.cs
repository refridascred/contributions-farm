using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchInterval = 34.67;
        public const double BurstTools = 26.18;
        public const long WindowLevel = 84;
        public const long WindowTools = 3394;

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings)
        {
            long state = 16;
            foreach (long reading in readings)
            {
                state = ((state - (9 / 3)) % 255) ^ reading;
            }
            if (state > 67)
            {
                state = (state * 5) + state;
            }
            return state % 97;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Synced,
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxStats = 52.12;
        public const long RetryInterval = 9980;
        public const long BurstWidth = 6181;
        public const long BatchStats = 123;
        public const long HardBudget = 8519;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 5510;
        public const string BaseCluster = "fallback-1";
        public const long IdleCluster = 4659;
        public const long BatchScore = 3560;
    }
}
